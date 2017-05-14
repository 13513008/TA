using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Accord.IO;
using Accord;
using Accord.Statistics.Models.Markov;
using Accord.Statistics.Models.Markov.Topology;
using Accord.Statistics.Models.Markov.Learning;
using Accord.Statistics.Distributions.Multivariate;
using Accord.Statistics.Distributions.Fitting;
using Accord.Statistics.Distributions.Univariate;

public class DanceHmm : MonoBehaviour {
	private static double[][][] sequences = new double[][][] {};
	private static int[] classes = new int[] {};
	private static string[] classesString = new string[] {};
	private static HiddenMarkovClassifier<MultivariateNormalDistribution, double[]> hmm; 
	private static bool isTraining;

	// Use this for initialization
	void Start () {
		hmm = new HiddenMarkovClassifier<MultivariateNormalDistribution,double[]>(classes.Length,new Forward(39), new MultivariateNormalDistribution(2), classesString); 
		
		// ReadFromFile("C:\\Users\\X200MA\\Desktop\\DEAL\\result10.txt");
		// Debug.Log(classesString.Length);
		// Debug.Log(classes.Length);
		// isTraining = true;
		Load("C:\\Users\\X200MA\\Desktop\\DEAL\\GendingSriwijaya.dat");
		// var trainingThread = new Thread(() => Train());
		// 	trainingThread.Start();
		// Load("C:\\Users\\X200MA\\Desktop\\savedata.txt");
		// Debug.Log(hmm.Decide(sequences[2]));
		// Debug.Log(hmm.LogLikelihood(sequences[2],2));
	}

	public void WriteToFile(string filePath, double[][] sequence) {
		using (System.IO.StreamWriter file = 
            new System.IO.StreamWriter(@filePath))
        {
            foreach (double[] pose in sequence)
            {
            	string line = "" + pose[0] + "," + pose[1] + "," + pose[2] + "," + pose[3] + "," + pose[4] + "," + pose[5];
                // If the line doesn't contain the word 'Second', write the line to the file.
                file.WriteLine(line);
            }
        }
	}

	public void ReadFromFile(string filePath) {
		List<double[][]> sequenceList = sequences.OfType<double[][]>().ToList();
		List<int> classList = classes.OfType<int>().ToList();
		List<string> classStringList = classesString.OfType<string>().ToList();

		var fileStream = new FileStream(@filePath, FileMode.Open, FileAccess.Read);
		using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
		{
		    string line;
		    List<double[]> list = new List<double[]>();
		    while ((line = streamReader.ReadLine()) != null)
		    {
		    	int classValue = getNewClass(line);
		        if (classValue != -1){
		        	if(classList.IndexOf(classValue) != -1){
			        	classStringList.Add(""+classValue);
			        }
			        classList.Add(classValue);
		        	sequenceList.Add(list.ToArray());
		        	list = new List<double[]>();
		        }else{
		        	list.Add(ParseLine(line));
		        }
		    }
		}
		sequences = sequenceList.ToArray();
		classes = classList.ToArray();
		classesString = classStringList.ToArray();
	}

	public double[] ParseLine(string line){
		char[] delimiterChars = new char[] {','};
		string[] numbers = line.Split(delimiterChars);
		double[] result = new double[numbers.Length];

		for(int i = 0; i < result.Length; i++){
			result[i] = double.Parse(numbers[i]);
		}
		return result;
	}

	public int getNewClass (string line) {
		char[] delimiterChars = new char[] {','};
		string[] numbers = line.Split(delimiterChars);

		if (numbers[0] == "class"){
			return Int32.Parse(numbers[1]);
		}else{
			return -1;
		}
	}

	public static void Train(){
		int states = 10;
		int iterations = 0;
		double tolerance = 0.01;
		bool rejection = false;

		// hmm = new HiddenMarkovClassifier<MultivariateNormalDistribution, double[]>(classesString.Length,
		// 		new Forward(states), new MultivariateNormalDistribution(6), classesString);

		var teacher = new HiddenMarkovClassifierLearning<MultivariateNormalDistribution, double[]>(hmm)
		{
		   // Train each model using the selected convergence criteria
		   Learner = i => new BaumWelchLearning<MultivariateNormalDistribution, double[]>(hmm.Models[i])
		   {
		       Tolerance = tolerance,
		       Iterations = iterations,

		       FittingOptions = new NormalOptions()
		       {
		          Regularization = 1e-5
		       }
		   }
		};

		teacher.Empirical = true;
		teacher.Rejection = rejection;
		// Debug.Log("Learn");
		teacher.Learn(sequences, classes);
		Save("C:\\Users\\X200MA\\Desktop\\DEAL\\GendingSriwijaya.dat");
		Debug.Log("Saved");
		// var result = hmm.Decide()

		// Save("C:\\Users\\X200MA\\Desktop\\gending_train.dat");
		// Save("C:\\Users\\X200MA\\Desktop\\gending_train.txt");
// After training has finished, we can check the 
// output classificaton label for some sequences. 

// int y1 = hmm.Compute(sequences[1]);    // output is y1 = 0
// Debug.Log(y1);
		// BaumWelchLearning teacher = new BaumWelchLearning(hmm);

		// // and call its Run method to start learning
		// double error = teacher.Run(inputSequences);
		// Debug.Log(error); 
		// // Let's now check the probability of some sequences:
		// double prob1 = Math.Exp(hmm.Evaluate(inputSequences[0]));   
		// Debug.Log(prob1);
	}

	public int Classify (double[][] movement) {
		// WriteToFile("C:\\Users\\X200MA\\Desktop\\detection.txt",movement);
		return hmm.Decide(movement);
	}

	public static void Save(string path){
		Serializer.Save<HiddenMarkovClassifier<MultivariateNormalDistribution,double[]>>(hmm,path);
	}

	public static void Load(string path){
		hmm = Serializer.Load<HiddenMarkovClassifier<MultivariateNormalDistribution,double[]>>(path);
	}

	// public void LoadClassifier(string filePath) {
	// 	hmm = HiddenMarkovClassifier<MultivariateNormalDistribution>.Load(filePath);
	// }

	// public static void Save(string filePath) {
	// 	hmm.Save(filePath);
	// 	Debug.Log("Saved");
	// }
	
	// Update is called once per frame
	void Update () {
		
	}
}
