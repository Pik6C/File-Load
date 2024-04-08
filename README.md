# File-Load
You can easily load files using C#

## how to use
### Read.File()
Read.File("[FilePass]","[Character code]")

### Read.FileLine()
Read.FileLine("[FilePass]","[Character code]")<br>
how to use:
```csharp
// Output to console line by line
foreach (var line in Read.FileLine("file.txt", "UTF-8"))
{
    Console.WriteLine(line);
}

// Use ToArray() to convert to array type and access index
string[] lines = Read.FileLine("file.txt", "UTF-8").ToArray();
string firstLine = lines[0];
string lastLine = lines[lines.Length - 1];

// Use ToList() to convert to List<string> and access index
List<string> linesList = Read.FileLine("file.txt", "UTF-8").ToList();
string firstLine = linesList[0];
string lastLine = linesList[linesList.Count - 1];

```

### Read.FileLineAsync()
Read.FileLineAsync("[FilePass]","[Character code]")<br>
ConfigureAwait(false) should be used to avoid blocking the UI thread
<br>
how to use:
```csharp
// Process one row at a time asynchronously
await foreach(var line in Read.FileLineAsync("file.txt", "UTF-8").ConfigureAwait(false)) 
{
    Console.WriteLine(line);
}
```
