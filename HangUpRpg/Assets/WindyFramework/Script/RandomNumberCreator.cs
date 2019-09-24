using System;
using System.Collections;
using System.Collections.Generic;

public class RandomNumberCreator {
	static private Random rd;

	static RandomNumberCreator(){
		rd = new Random ();
	}

	static public int GetAInt(int ubound){
		return rd.Next (ubound);
	}
}
