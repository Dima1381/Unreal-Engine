using UnrealBuildTool;

public class PassingObstaclesEditorTarget : TargetRules
{
	public PassingObstaclesEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("PassingObstacles");
	}
}
