﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShootingRange.BusinessObjects;
using ShootingRange.Entities;

namespace ShootingRange.Repository.Mapper
{
  internal static class ShooterMapper
  {
    public static t_shooter UpdateEntity(this t_shooter entity, Shooter shooter)
    {
      entity.ShooterNumber = shooter.ShooterNumber;
      entity.PersonId = shooter.PersonId;
      return entity;
    }
  }


  internal static class ShotMapper
  {
    public static t_shot UpdateEntity(this t_shot entity, Shot shot)
    {
      entity.PrimaryScore = shot.PrimaryScore;
      entity.SecondaryScore = shot.SecondaryScore;
      entity.ShotOrdinal = shot.Ordinal;
      entity.ValueX = shot.ValueX;
      entity.ValueY = shot.ValueY;
      entity.SubtotalId = shot.SubtotalId;
      return entity;
    }
  }
}
