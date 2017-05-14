/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nusantari;

import java.util.*;
import be.ac.ulg.montefiore.run.jahmm.*;
import be.ac.ulg.montefiore.run.jahmm.toolbox.*;
import be.ac.ulg.montefiore.run.jahmm.learn.*;
import be.ac.ulg.montefiore.run.jahmm.draw.*;
import java.io.IOException;
import controller.ControllerServer;

/**
 *
 * @author X200MA
 */
public class Nusantari {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws IOException {
        /* 42 sequences of observations, each with 100 coin flips */
	int[][] data = {{0, 1, 1, 1, 1, 1, 1}, {0, 1, 1, 1}, {0, 1, 1, 1, 1}, {0, 1}, {0, 1, 1}};

	
	/* Read data into Observation sequences */
	Vector sequences = new Vector();
	for (int i = 0; i < data.length; i++) {
	    Vector sequence = new Vector();
	    for (int j=0; j< data[i].length; j++) {
		ObservationInteger obs = new ObservationInteger(data[i][j]);
		sequence.add(obs);
	    }
	    sequences.add(sequence);
	}

	/* K-Means approximation derives the initial HMM */
	KMeansLearner kml = new KMeansLearner(2, new OpdfIntegerFactory(2), sequences); 
	Hmm initHmm = kml.learn();

	/* Baum-Welch learning refines the HMM for another 11 iterations*/
	BaumWelchLearner bwl = new BaumWelchLearner();
        bwl.setNbIterations(2);

	Hmm learntHmm = bwl.iterate(initHmm,sequences);
	for (int i = 0; i < 10; i++) {
	    learntHmm = bwl.iterate(learntHmm,sequences);
	}

	/* Write the final result to a 'dot' (graphviz) file. */
	(new GenericHmmDrawerDot()).write(learntHmm, "learntHmm.dot");
//        for(int i = 0; i < 42; i++){
            
//        }

        Vector sequencea = new Vector();
	    for (int j=0; j<5; j++) {
		ObservationInteger obs = new ObservationInteger(1);
		sequencea.add(obs);
	    }
            for (int j=5; j<10; j++) {
		ObservationInteger obs = new ObservationInteger(0);
		sequencea.add(obs);
	    }
            
        Vector sequenceb = new Vector();
	    for (int j=0; j<2; j++) {
		ObservationInteger obs = new ObservationInteger(0);
		sequenceb.add(obs);
	    }
        
        System.out.println(learntHmm.lnProbability((List) sequences.get(0)));
        System.out.println(learntHmm.lnProbability((List) sequencea));
        System.out.println(learntHmm.lnProbability((List) sequenceb));
    }
    
}
