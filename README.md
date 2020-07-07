[![Latest nuget release](https://img.shields.io/nuget/v/OracleClientExtension?style=flat-square&label=nuget)](https://www.nuget.org/packages/OracleClientExtension)

![](https://github.com/sdaniil/OracleClientExtension/blob/master/OracleClientExtension/images/OracleClientExtesion.png)

# OracleClientExtension
This is a tiny library with which you can extend the possibilities of the OracleClient. Easy way to get Entities, ExpandoObjects and much more.

## Features
- Retrive data as ExpandoObject
- Retrive data as Entity T
- Test
- 

## Installing
#### Via Package Manager 
```powershell
Install-Package OracleClientExtension -Version 0.2.4
```
#### Via .NET CLI
```powershell
dotnet add package OracleClientExtension --version 0.2.4
```

## Samples
#### Get data from table as ExpandoObjects
```c#
private readonly string _connectionString = "Data Source=localhost/XE;Persist Security Info=True;User ID=USER;Password=PASSWORD";
...
try
{
    await using var conn = new OracleConnection(connectionString: _connectionString);
    await conn.OpenAsync();
    var resp = await conn.ExecuteExpandoObjectsAsync("SELECT * FROM DEMO WHERE ROWNUM <= 10");
}
catch (Exception ex)
{
    throw ex;
}
```

#### Get data from table as custom Entity object
```c#
private readonly string _connectionString = "Data Source=localhost/XE;Persist Security Info=True;User ID=USER;Password=PASSWORD";
...
public class DemoEntity
{
		public int EMPNO { get; set; }
		public string ENAME { get; set; }
		public string JOB { get; set; }
		public DateTime HIREDATE { get; set; }
		public int DEPTNO { get; set; }
}
...
try
{
    await using var conn = new OracleConnection(connectionString: _connectionString);
    await conn.OpenAsync();
    var resp = await conn.ExecuteEntitiesAsync<DemoEntity>("SELECT * FROM DEMO WHERE ROWNUM <= 10");
}
catch (Exception ex)
{
    throw ex;
}
```

## Todo
- [ ] Add Sample app
- [ ] Add Tests
- [ ] Add documentation

Pull requests are more than welcomed!

## License
>You can check out the full license [here](https://github.com/sdaniil/OracleClientExtension/blob/master/LICENSE)

This project is licensed under the terms of the **MPL-2.0** license.
