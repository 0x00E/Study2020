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
			p(d);
			if(true){
				p(1);
			}else{
				p(3);
			}
			int i=1;
			while(true){
				p(i);
				if(++i==10)
				  break;
			}
			int j=1;
			do{
				p(j++);
			}while(j<=10);
			
			for(int k=0;k<9;k++)
			  p(k);
			  
			char cxx='z';
		    switch(cxx){
		    	case 'z':
		    	  p(568);
		    	  break;
		    	case 'b':
		    	  p(865);
		    	  break;
		    }
            test:
            	p(666999);
            
            //666
            //goto test;
		    
		    
			
		    
			
        }
        
        public static void p(Object obj){
        	Console.WriteLine(obj);
        }
    }
}