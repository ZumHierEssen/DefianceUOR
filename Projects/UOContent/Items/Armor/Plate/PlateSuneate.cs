namespace Server.Items
{
    public class PlateSuneate : BaseArmor
    {
        [Constructible]
        public PlateSuneate() : base(0x2788) => Weight = 7.0;

        public PlateSuneate(Serial serial) : base(serial)
        {
        }

        public override int BasePhysicalResistance => 5;
        public override int BaseFireResistance => 3;
        public override int BaseColdResistance => 2;
        public override int BasePoisonResistance => 3;
        public override int BaseEnergyResistance => 2;

        public override int InitMinHits => 55;
        public override int InitMaxHits => 65;

        public override int AosStrReq => 80;
        public override int OldStrReq => 80;

        public override int ArmorBase => 3;

        public override ArmorMaterialType MaterialType => ArmorMaterialType.Plate;

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
