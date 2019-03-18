﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using LinqToDB.Expressions;
using LinqToDB.Linq.Parser.Clauses;

namespace LinqToDB.Linq.Parser.Builders
{
	public class UnionBuilder : BaseSetBuilder
	{
		private static readonly MethodInfo[] _supported =
			{ ParsingMethods.Union };

		public override MethodInfo[] SupportedMethods() => _supported;

		protected override BaseSetClause CreateSetClause(Type itemType, string itemName, Sequence sequence1, Sequence sequence2)
		{
			return new UnionClause(itemType, itemName, sequence1, sequence2);
		}

	}
}