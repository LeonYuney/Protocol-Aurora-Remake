using UnrealBuildTool;

public class ProtocolAuroraRemakeServerTarget : TargetRules
{
	public ProtocolAuroraRemakeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ProtocolAuroraRemake");
	}
}
