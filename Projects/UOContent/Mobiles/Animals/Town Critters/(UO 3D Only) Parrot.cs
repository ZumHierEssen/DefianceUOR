namespace Server.Mobiles
{
    public class Parrot : BaseCreature
    {
        [Constructible]
        public Parrot() : base(AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            Body = 831;
            VirtualArmor = Utility.Random(0, 6);

            InitStats(10, Utility.Random(25, 16), 10);

            Skills.Wrestling.Base = 6;
            Skills.Tactics.Base = 6;
            Skills.MagicResist.Base = 5;

            Fame = Utility.Random(0, 1249);
            Karma = Utility.Random(0, -624);

            Tamable = true;
            ControlSlots = 1;
            MinTameSkill = 0.0;
        }

        public Parrot(Serial serial) : base(serial)
        {
        }

        public override string CorpseName => "a parrot corpse";
        public override string DefaultName => "a parrot";

        public override int GetAngerSound() => 0x1B;

        public override int GetIdleSound() => 0x1C;

        public override int GetAttackSound() => 0x1D;

        public override int GetHurtSound() => 0x1E;

        public override int GetDeathSound() => 0x1F;

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0);
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}
