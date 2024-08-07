﻿using design_patterns.src.Adapter;
using design_patterns.src.ChainOfResponsibility;
using design_patterns.src.Facade;
using design_patterns.src.Factory;
using design_patterns.src.Proxy;
using design_patterns.src.Singleton;
using design_patterns.src.Singleton.EcommerceSample;
using design_patterns.src.Strategy;

Console.WriteLine("WELCOME TO DESIGN PATTERNS IN C#!");

Console.WriteLine("\n---------------- Singleton Pattern 🚀");
SingletonUsage.SampleOne();
SingletonEcommerce.Usage();

Console.WriteLine("\n---------------- Factory Pattern 🚀");
FactoryNetworkUsage.SampleOne();

Console.WriteLine("\n---------------- Facade Pattern 🚀");
FacadeUsage.SampleOne();

Console.WriteLine("\n---------------- Adapter Pattern 🚀");
AdapterUsage.SampleOne();

Console.WriteLine("\n---------------- Proxy Pattern 🚀");
ProxyUsage.SampleOne();

Console.WriteLine("\n---------------- ChainOfResponsibility Pattern 🚀");
ChainOfResponsibilityUsage.SampleOne();

Console.WriteLine("\n---------------- Strategy Pattern 🚀");
StrategyPatternUsage.SampleOne();