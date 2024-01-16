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
## Code Generator
> Main generation class. Since we are not allowed to store codes (coupons), we display codes via seperated method by recreating them.


```
<uses CharacterSet>
public class CodeGenerator: 
  * public static string[] GenerateCoupons() - password, code number
  * public static void DisplayCoupons() - password, code number
  * static string[] GenerateCodes() - System.Random, code number, [code length]
  * static void DisplayCodes() - System.Random, code number, [code length]
```


- password: Password (seed) for code validation. It basically an integer number, Max range is 2^32 and max value is 2,147,483,647.
- code number: How much code do you want to generate.
- System.Random: [System.Random](https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0)
> [!WARNING]
> [code length]: Optional, default is 8. It is "possible" make user able to change it, but in this case we do not want that.
> 
> As an example, let's assume our CharacterSet is 23 units long. There will be 78,310,985,281 (23^8) possible unique numbers (we presume repetitive patterns are OK like AAAAAAAA).
> 
> ~78 billion / ~2 billion = 39.
> 
> ~78 billion / ~1 million = 78000. Which is 78000 different campaings, each time unique 1 million codes.


	


## Configurator
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

