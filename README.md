# Memory Safe .NET Demo

This repository contains multiple small demo projects for .NET memory leaks and best practices:
- **AnalyzerDemo**: Triggers analyzers for disposal and async/task safety
- **KafkaLeakDemo**: Simulates missing IDisposable with a fake Kafka producer
- **DbContextLeakDemo**: Shows common DbContext disposal mistakes
- **StaticCollectionDemo**: Demonstrates static memory bloat

Open any project in Visual Studio 2022+, build, and observe warnings in the Error List.

See [Blog](https://medium.com/@siva_bankapalli/memory-safe-net-patterns-pitfalls-and-production-proven-fixes-f017ca67a6ad) for the full article.
