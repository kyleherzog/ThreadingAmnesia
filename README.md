# Threading Amnesia

[![Build status](https://ci.appveyor.com/api/projects/status/gmvrjms5y52fl8gw?svg=true)](https://ci.appveyor.com/project/kyleherzog/threadingamnesia)

This library is available from [NuGet.org](https://www.nuget.org/packages/ThreadingAmnesia/)
or download from the [CI build feed](https://ci.appveyor.com/nuget/ThreadingAmnesia).

--------------------------

A .NET Standard class library that simply adds the extension method Forget to the Task object.  The Forget method really does nothing but explicitly indicate to the reader of the code that the return of the Task will not be monitored.  This also prevents code analysis warnings.


See the [changelog](CHANGELOG.md) for changes and roadmap.

### Example

```c#
SomeMethodAsync().Forget();
```


## License
[Apache 2.0](LICENSE)