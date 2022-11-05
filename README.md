## 前言

Entity Framework Core可通过名为数据库提供程序的插件库访问许多不同的数据库。

作为[《乘风破浪，遇见最佳跨平台跨终端框架.Net Core/.Net生态 - 适用于Entity Framework Core的命令行(CLI)工具集(Dotnet-EF)》](https://www.cnblogs.com/taylorshi/p/16843914.html)以及[《乘风破浪，遇见最佳跨平台跨终端框架.Net Core/.Net生态 - 浅析ASP.NET Core领域驱动设计，通过MediatR中介者模式实现CQRS和领域事件》](https://www.cnblogs.com/taylorshi/p/16794364.html)的姊妹篇，这里将梳理在Entity Framework Core的广泛数据库提供程序支持下，如何实现数据库的Docker创建和简单对接。

## 相关文章

* [乘风破浪，遇见最佳跨平台跨终端框架.Net Core/.Net生态 - 数据持久化设计，基于Entity Framework Core和其广泛的数据库提供程序](https://www.cnblogs.com/taylorshi/p/16861628.html)