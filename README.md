# Options Injection Pattern
Description and sample of the Options Injection Pattern.

## Quick Start Guide

Clone the repository and open with Visual Studio 2015. 
Samples is built using C# and uses [xunit](http://xunit.github.io/) for unit testing.

## Pattern Description

Object-oriented pattern for strongly typed options in software system. Instead of using a more
generic repository for settings, each individual domain/business object that needs some options/settings,
can get those injected as an instance of the class. 

## Benefits

* Clearly communicates the options required for a domain/business object to function.
* Options can be supplied through runtime easily.
* Options can be supplied with normal new of objects, or through Dependecy Injection with Inversion of Control.
* The actual values for options can be retreive from any number of sources at runtime: JSON files, INI files, XML
files, Web Services, databases and more.

## Code

Options is defined as standalone C# types, with no dependencies:
```csharp
    public class FingerOptions
    {
        public int Joints { get; set; }
    
        public int Index { get; set; }
    
        public string ConnectionString { get; set; }
    }
```

Options is injected into the constructor of the domain object:
```csharp
    public Finger(FingerOptions options, Func<Bone> boneFactory)
```

Instances of options can be registered in the IoC container:
```csharp
    builder.RegisterInstance(new FingerOptions()
    {
        Index = 0,
        Joints = 3,
        ConnectionString = "name:ReplicantLeftArm"
    });
```

## Sample Projects

* **OptionsInjectionPattern**: Uses Autofac for IoC and shows example of default options in the module and override
in the unit test project.

## Final Notes

Any [software pattern](http://www.martinfowler.com/articles/writingPatterns.html) is never a silver bullet that can be used across any type of software or system. This
pattern works well for many styles of software implementations.

## License

MIT © [Sondre Bjellås](http://sondreb.com)
