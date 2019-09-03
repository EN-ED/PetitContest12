using UnrealBuildTool;

public class PetitContest12Target : TargetRules
{
	public PetitContest12Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("PetitContest12");
	}
}
