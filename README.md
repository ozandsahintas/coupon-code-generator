# coupon-code-generator
A simple coupon code generator.

~ Code Spectrum ~ 

```Csharp
Program.cs: Main entry point.

CodeGenerator.cs: 
  * public GenerateCoupons()
  * public DisplayCoupons()
  * GenerateCodes()
  * DisplayCodes()

CodeValidator.cs:
  * public ValidateCoupons()
  * ValidateCodes()

Configurator.cs
  * AppSettings["CharacterSet"]
  * AppSettings["Generations"]
```
> I don't like pushing config files to the GitHub.

Here is the simple App.config file, there is also an App.config file in the project with empty values.
```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<appSettings>
		<add key="CharacterSet" value="" />
		<add key="Generations" value="" />
	</appSettings>
</configuration>

```

