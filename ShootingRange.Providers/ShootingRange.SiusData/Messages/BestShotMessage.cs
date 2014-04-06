using System;
using System.Diagnostics;

namespace ShootingRange.SiusData.Messages
{
  [DebuggerDisplay("Lane {LaneId}; PrimaryScore {PrimaryScore}")]
  public class BestShotMessage : SiusDataMessage
  {
    public BestShotMessage(int shooterId, int laneId, DateTime timestamp, double primaryScore, double secondaryScore,
      int shotNbr, int programNumber)
    {
      ShooterId = shooterId;
      LaneId = laneId;
      Timestamp = timestamp;
      PrimaryScore = primaryScore;
      SecondaryScore = secondaryScore;
      ShotNbr = shotNbr;
      ProgramNumber = programNumber;
    }

    public SiusDataMessageProcessDelegate<BestShotMessage> ProcessDelegate { get; set; }

    public int ShooterId { get; private set; }

    public int LaneId { get; private set; }

    public DateTime Timestamp { get; private set; }

    public double PrimaryScore { get; private set; }

    public double SecondaryScore { get; private set; }

    public int ShotNbr { get; private set; }

    public int ProgramNumber { get; private set; }

    public override void Process()
    {
      if (ProcessDelegate != null)
      {
        ProcessDelegate(this);
      }
    }
  }
}