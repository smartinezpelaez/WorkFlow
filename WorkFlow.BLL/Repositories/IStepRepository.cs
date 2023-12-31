﻿using WorkFlow.DAL.Models;

namespace WorkFlow.BLL.Repositories;

public interface IStepRepository : IGenericRepository<Step>
{
    IEnumerable<Step> GetStepsByFlowId(int flowId);

    
}
