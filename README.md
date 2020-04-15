---
page_type: sample
languages:
- csharp
products:
- dotnet
- dotnet-core
- azure-table-storage
description: This repo contains basic samples that demonstrate how to use the Azure Cosmos DB Table library to manage Azure Table Storage tables.
---

# Table Storage samples with the Azure Cosmos DB Table library

![GitHub Actions status](https://github.com/CodeRunRepeat/table-storage-samples-csharp-2/workflows/build/badge.svg)

This repo contains basic samples that demonstrate how to use the [Azure Cosmos DB Table library](https://docs.microsoft.com/en-us/azure/cosmos-db/table-sdk-dotnet-standard) to manage Azure Table Storage tables.

Samples are based on [version 1.0.6](https://www.nuget.org/packages/Microsoft.Azure.Cosmos.Table/1.0.6) of the library NuGet package.

## Contents

The samples are based on a book entity with author, title, publication date, and ISBN, stored in a table with the author name
as the partition key and the ISBN as row key. The approach intends to demonstrate how to use the APIs and is definitely not
a recommendation on how to partition and store similar information.

| File/folder       | Description                                |
|-------------------|--------------------------------------------|
| `src`             | Sample source code.                        |
| `src/Shared`      | Contains the definition for the BookEntity and sample data loading. The connection string for the Table Storage service is retrieved from an environment variable. |
| `src/QueryData`    | Demonstrates how to query data in a table using filters, ordering, and top N items. |
| `.gitignore`      | Define what to ignore at commit time.      |
| `CHANGELOG.md`    | List of changes to the sample.             |
| `CONTRIBUTING.md` | Guidelines for contributing to the sample. |
| `README.md`       | This README file.                          |
| `LICENSE`         | The license for the sample.                |

## Prerequisites

Visual Studio 2019 or VSCode.

## Setup

Open `src/Samples.sln` in Visual Studio 2019 or the `src` folder in VSCode.
Add your Table Storage connection string in the StorageConnectionString environment variable.

* Visual Studio 2019: Open the `QueryData` project properties and add it in the `Debug` page.
* VSCode: Edit `.vscode/launch.json` and add `"env": { "StorageConnectionString": "your connection string" }` to your `configurations` section.

## Running the sample

Outline step-by-step instructions to execute the sample and see its output. Include steps for executing the sample from the IDE, starting specific services in the Azure portal or anything related to the overall launch of the code.

## Key concepts

Run or step through Program.cs in the QueryData project.

## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit [https://cla.opensource.microsoft.com](https://cla.opensource.microsoft.com).

When you submit a pull request, a CLA bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
