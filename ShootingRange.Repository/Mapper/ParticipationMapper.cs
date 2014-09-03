﻿using ShootingRange.BusinessObjects;
using ShootingRange.Entities;

namespace ShootingRange.Repository.Mapper
{
  internal static class ParticipationMapper
  {
    public static t_participation UpdateEntity(this t_participation entity, Participation participation)
    {
      entity.Description = participation.ParticipationName;
      entity.AllowCollectionParticipation = participation.AllowCollectionParticipation;
      entity.AllowSingleParticipation = participation.AllowSingleParticipation;

      return entity;
    }
  }
}
