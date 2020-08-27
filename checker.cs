using System;
using System.Diagnostics;

class Checker
{	
	static bool VitalsIsInsideLimit(float value,int lowerlimit, int upperlimit)
	{
		return(value>=lowerlimit && value <=upperlimit);
	}
	
    static bool VitalsAreOk(float bpm, float spo2, float respRate) {
        return(VitalsIsInsideLimit(bpm,70,150) && VitalsIsInsideLimit(spo2,90,100) && VitalsIsInsideLimit(respRate,30,95));
    }
	
    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
	
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
	
    static int Main() {
		ExpectTrue(VitalsIsInsideLimit(40,30,90));
		ExpectFalse(VitalsIsInsideLimit(20,30,90));
        ExpectTrue(VitalsAreOk(100, 95, 60));
        ExpectFalse(VitalsAreOk(40, 91, 92));
		ExpectTrue(VitalsAreOk(110,95,60));
        Console.WriteLine("All ok");
        return 0;
    }
}
