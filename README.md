# Purchase Serialize/Deserialize Sample

## What does this solution do?

This solution demonstrates serialization and deserialization of `Purchase` objects (containing lists of `Product` items and associated `Customer` data) to and from JSON using `System.Text.Json`. It showcases a layered architecture with Business Entities (BE), Business Logic Layer (BLL), and Data Access Layer (DAL), including file-based persistence for historical purchases.

- `Purchase_Serialize_Deserialize_Sample` project: Creates a sample `Purchase` with hardcoded `Product` items and a `Customer`, serializes it to indented JSON, and writes a file named `purchase{IdPurchase}.json` to the `Desktop/Purchases/` directory. Prints the JSON and full file path.
- `Purchase_Deserialize` project: Reads a JSON file (configured via `appsettings.json`), deserializes it back into a `Purchase` object, and prints a human-readable representation.
- `Purchases_Serialize` project: Similar to the first serializer but handles multiple purchases, loading existing ones from file, adding a new one, and serializing the list to `Purchases.json`.
- `BE` project: Contains model classes (`Purchase`, `Product`, `Customer`, `MaritalStatus`) and repository interfaces.
- `BLL` project: Business logic layer with classes like `BLLCustomer`, `BLLProduct`, and `BLLPurchase` for data operations.
- `DAL` project: Data access layer with hardcoded sample data (`DALCustomer`, `DALProduct`) and file-based storage for purchases (`DALPurchase`).

The projects target .NET Framework 4.7.2 and are written in C# 7.3, using a repository pattern for data management.

## How to use the solution

### Prerequisites
- Windows OS (required for .NET Framework 4.7.2).
- Visual Studio 2019 or later (with .NET Framework 4.7.2 support).
- Git for cloning the repository.

### Steps to Set Up and Run

1. **Clone the Repository**:
   - Open a terminal or command prompt.
   - Run: `git clone https://github.com/IfreneArlandoArg/Purchase_Serialize_Deserialize_Sample.git`
   - Navigate to the cloned directory: `cd Purchase_Serialize_Deserialize_Sample`

2. **Open in Visual Studio**:
   - Launch Visual Studio.
   - Open the solution file: `Purchase_Serialize_Deserialize_Sample.sln`.

3. **Restore NuGet Packages** (if needed):
   - In Visual Studio, right-click the solution in Solution Explorer and select "Restore NuGet Packages".
   - Alternatively, run `nuget restore Purchase_Serialize_Deserialize_Sample.sln` in the terminal.

4. **Build the Solution**:
   - In Visual Studio, select "Build" > "Build Solution" (or press Ctrl+Shift+B).

5. **Run the Serializer**:
   - Set `Purchase_Serialize_Deserialize_Sample` as the startup project (right-click the project in Solution Explorer > "Set as StartUp Project").
   - Run the project (F5 or Ctrl+F5).
   - It will create a JSON file in `Desktop/Purchases/purchase{GUID}.json`, print the JSON, and display the file path. Copy the full path from the output.

6. **Configure and Run the Deserializer**:
   - Switch to the `Purchase_Deserialize` project (set as startup).
   - Open `Purchase_Deserialize/appsettings.json`.
   - Replace the `FilePath` value with the full path copied from step 5 (e.g., `"C:\\Users\\YourUser\\Desktop\\Purchases\\purchase93b9ab16-e65f-4e92-8d39-7c27bc394c43.json"`).
   - Run the project (F5 or Ctrl+F5).
   - It will deserialize the JSON and print the purchase details.

### Optional: Run the Multiple Purchases Serializer (*See Note*)
- Set `Purchases_Serialize` as the startup project.
- Run it to serialize a list of purchases (including historical ones from file) to `Desktop/Purchases/Purchases.json`.

The solution uses hardcoded data in the DAL layer for demonstration. 
For production use, implement full CRUD operations in the repository classes.

**Note**: 
This solution is designed for use with *local directories only* and *does not support remote file systems or cloud storage*.
Feel free to add this behaviour if judged necessary...




