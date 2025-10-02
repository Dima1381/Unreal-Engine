using UnrealBuildTool;

public class PassingObstaclesClientTarget : TargetRules
{
	public PassingObstaclesClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("PassingObstacles");
	}
}
