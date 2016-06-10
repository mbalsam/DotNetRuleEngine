﻿using System;
using System.Linq.Expressions;
using DotNetRuleEngine.Core.Interface;

namespace DotNetRuleEngine.Core
{
    internal class RuleEngineConfiguration<T> : IRuleEngineConfiguration<T>
    {
        public RuleEngineConfiguration(IConfiguration<T> configuration)
        {
            Constraint = configuration.Constraint;
            ExecutionOrder = configuration.ExecutionOrder;
            Skip = configuration.Skip;
            Terminate = configuration.Terminate;
            InvokeNestedRulesFirst = configuration.InvokeNestedRulesFirst;
            NestedRulesInheritConstraint = configuration.NestedRulesInheritConstraint;
        }

        public Guid RuleEngineId { get; set; }

        public Expression<Predicate<T>> Constraint { get; set; }

        public int? ExecutionOrder { get; set; }

        public bool Skip { get; set; }

        public bool? Terminate { get; set; }

        public bool InvokeNestedRulesFirst { get; set; }

        public bool NestedRulesInheritConstraint { get; set; }
    }
}