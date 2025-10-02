using UnrealBuildTool;

public class PassingObstaclesTarget : TargetRules
{
	public PassingObstaclesTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PassingObstacles");
	}
}
