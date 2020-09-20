using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace com.qianniancc{


    public class Program 
    {
        public static void Main()
        {
			int a=1;
			byte b=1;
			char c='a';
			double d=1.9f;
			float f=1.9f;
			short s=12;
			long l=1234567890;
			String str="test";
			print(d);
        }
        
        public static void print(Object obj){
        	Console.WriteLine(obj);
        }
    }
}