using UnrealBuildTool;

public class TowerDefenseTarget : TargetRules
{
	public TowerDefenseTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V7;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_8;
		ExtraModuleNames.Add("TowerDefense");
	}
}
