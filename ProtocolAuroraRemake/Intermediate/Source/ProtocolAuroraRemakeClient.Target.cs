using UnrealBuildTool;

public class ProtocolAuroraRemakeClientTarget : TargetRules
{
	public ProtocolAuroraRemakeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ProtocolAuroraRemake");
	}
}
