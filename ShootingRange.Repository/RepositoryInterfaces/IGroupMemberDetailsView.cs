﻿using System.Collections.Generic;
using ShootingRange.BusinessObjects;

namespace ShootingRange.Repository.RepositoryInterfaces
{
  public interface IGroupMemberDetailsView : IDataView<GroupMemberDetails>
  {
    IEnumerable<GroupMemberDetails> FindByGroupId(int groupId);
    IEnumerable<GroupMemberDetails> FindByShooterId(int shooterId);
    IEnumerable<GroupMemberDetails> FindByPersonId(int personId);
  }
}
