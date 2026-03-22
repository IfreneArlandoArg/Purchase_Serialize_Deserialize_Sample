# Purchase Serialize/Deserialize Sample

## What does this solution do?

This solution demonstrates simple serialization and deserialization of a `Purchase` object (which contains a list of `Product` items) to and from JSON using `System.Text.Json`.

- `Purchase_Serialize_Deserialize_Sample` project: creates a `Purchase` with sample `Product` items, serializes it to indented JSON and writes a file named `purchase{IdPurchase}.json` to the current working directory. The program prints the JSON and the full file path.
- `Purchase_Deserialize` project: reads a JSON file previously created by the serializer, deserializes it back into a `Purchase` object and prints a human-readable representation.
- `BE` project: contains the model classes `Purchase` and `Product` used by both projects.

The projects target .NET Framework 4.7.2 and are written in C# 7.3.

## How to use

Quick summary:

1. First, run the serializer to generate the JSON file and copy the filepath printed in the terminal.
2. Then switch to the deserializer project, paste that full *FilePath* into `Purchase_Deserialize\appsettings.json` , build and run the deserializer.

Detailed steps:

1. Open the solution in Visual Studio (any version that supports .NET Framework 4.7.2).
2. Set `Purchase_Serialize_Deserialize_Sample` as the startup project, build and run it.
   - The program will serialize a `Purchase` and write a file named like `purchase{IdPurchase}.json` to its working directory.
   - The terminal will print the full file path (for example: `C:\path\to\purchase{IdPurchase}.json`). Copy that full path.
3. Change to the `Purchase_Deserialize` project:
   - Open `Purchase_Deserialize\appsettings.json` and replace the *Value* of the field *FilePath* with the filepath, you copied previously(). 
4. Set `Purchase_Deserialize` as the startup project, build and run it.
   - The program will read the JSON file, deserialize it into a `Purchase`, and print the result.

