using System.Text.RegularExpressions;
using LINQExamples_1.src;
using LINQExamples_1.src.LINQ_Operators;

Console.WriteLine("LINE EXAMLE ONE!");

//------- Select and Extensions Methods
Console.WriteLine("\n------- Select and Extensions Methods");
SampleOne.SelectAndWhere();
SampleOne.QuerySyntax();
SampleOne.DeferredEnumberableExtensionUsage();
SampleOne.ImmediateEnumberableExtensionUsage();

//------- Join Operator
Console.WriteLine("\n------- Join Operator");
JoinOperator.MethodSyntax();
JoinOperator.GroupJoinMethodSyntax();
JoinOperator.GroupJoinQuerySyntax();

//------- LINQ Operators
Console.WriteLine("\n------- LINQ Operator");
SortingOperators.OrderByMethodSyntax();
SortingOperators.OrderByQuerySyntax();
GroupingOperators.GroupByQuerySyntax();
GroupingOperators.ToLookUpOperator();
QualifierOperators.AllAndAnyOperators();
QualifierOperators.ContainsOperator();
FilterOperators.FilterOperatorQuerySyntax();
ElementOperator.ElementAtSample();
ElementOperator.FirstOrDefaultSample();
ElementOperator.LastOrDefaultSample();
ElementOperator.SingleOrDefaultSample();

//------- More LINQ Operators
Console.WriteLine("\n------- More LINQ Operator");
EqualityOperator.SequenceEqual();
ConcatenationOperator.ConcatSample();
AggregateOperator.AggregateSample();
AggregateOperator.AverageSample();
AggregateOperator.CountSample();
AggregateOperator.SumSample();
AggregateOperator.MaxSample();
GenerationOperator.DefaultIfEmpty();
GenerationOperator.EmptySample();