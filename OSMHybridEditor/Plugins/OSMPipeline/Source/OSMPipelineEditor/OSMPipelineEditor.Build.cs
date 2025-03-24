//Copyright 2025 Pure Light Studio. All Rights Reserved.
//Copyright Hoshino Kennji.

using UnrealBuildTool;

public class OSMPipelineEditor : ModuleRules
{
	public OSMPipelineEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
			{ "Core", "CoreUObject", "Engine", "InputCore", "UnrealEd", "OSMPipeline" });
		PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore", "UnrealEd", "AssetTools", "UMG" });
	}
}