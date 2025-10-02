using UnrealBuildTool;

public class PassingObstaclesServerTarget : TargetRules
{
	public PassingObstaclesServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("PassingObstacles");
	}
}
