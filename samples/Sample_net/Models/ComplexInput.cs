﻿using Swashbuckle.Examples.Auto;

namespace Sample_net.Models
{
	public class ComplexInput
	{
		[Sample('a')]
		public char C { get; set; }
		[Sample(33)]
		public int I { get; set; }
	}
}