﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityIoC.Editor
{
	
	public class TestClass : TestInterface {
		public string JustAProperty { get; set; }

		public void DoSomething()
		{
			MyDebug.Log("TestClass"); 
		}
	}
}