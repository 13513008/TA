using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Controller;
using net.sf.jni4net;

//using controller;


public class ControllerServer
{
	private Controller.ControllerServer CS;

	public void main()
	{
		var bridgeSetup = new BridgeSetup();
		CS = new Controller.ControllerServer();
		bridgeSetup.AddAllJarsClassPath(".");
		Bridge.CreateJVM(bridgeSetup);
		Bridge.RegisterAssembly(typeof(ControllerServer).Assembly);

		ControllerServer CS = new ControllerServer();
		CS.startServer();
	}
}