﻿using System;
using NUnit.Framework;

namespace Swashbuckle.Examples.Auto.Tests
{
	[TestFixture]
	public class BuildSampleAttributeTester
	{
		[Test]
		public void Attribute_ApplyToClasses()
		{
			Assert.That(typeof(SamplifyAttribute), Has.Attribute<AttributeUsageAttribute>()
				.With.Property(nameof(AttributeUsageAttribute.ValidOn)).EqualTo(AttributeTargets.Class));
		}

		[Test]
		public void Ctor_Default_NullProxyType()
		{
			var subject = new SamplifyAttribute();

			Assert.That(subject.TypeOfSample, Is.Null);
		}

		[Test]
		public void Ctor_NullTypeOfSample_NoException()
		{
			Assert.That(() => new SamplifyAttribute(null), Throws.Nothing, "As it there was no proxy type");
		}

		[Test]
		public void Ctor_NotNullTypeOfSample_SetProxyType()
		{
			var subject = new SamplifyAttribute(typeof(string));

			Assert.That(subject.TypeOfSample, Is.SameAs(typeof(string)));
		}
	}
}