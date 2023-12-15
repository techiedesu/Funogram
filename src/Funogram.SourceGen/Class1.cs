using System.Text.Json.Serialization;

namespace Funogram.SourceGen;

[JsonSerializable(typeof(Funogram.Generator.Types.Types.ApiType[]))]
[JsonSerializable(typeof(Funogram.Generator.Types.Types.ApiTypeField[]))]
[JsonSerializable(typeof(Funogram.Generator.Types.Types.ApiTypeCase[]))]
[JsonSerializable(typeof(Funogram.Generator.Types.Types.ApiTypeField[]))]
[JsonSerializable(typeof(Funogram.Generator.Types.Types.ApiTypeKind[]))]
[JsonSerializable(typeof(Funogram.Generator.Types.Types.ApiTypeNodeInfo[]))]
public sealed partial class GeneratorTypes : JsonSerializerContext;

[JsonSerializable(typeof(Funogram.Generator.Methods.Types.ApiType[]))]
public sealed partial class GeneratorMethods : JsonSerializerContext;