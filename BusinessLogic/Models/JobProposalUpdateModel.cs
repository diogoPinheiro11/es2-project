﻿namespace BusinessLogic.Models;

public class JobProposalUpdateModel
{
    public int ClientID { get; set; }
    public string Name { get; set; }
    public string TalentCategory { get; set; }
    public int TotalHours { get; set; }
    public string JobDescription { get; set; }
    public List<JobProposalSkillModel> JobproposalSkill { get; set; }
}