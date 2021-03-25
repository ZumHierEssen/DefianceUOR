namespace Server.Items
{
    [Flippable(0x2B6B, 0x3162)]
    public class WoodlandLegs : BaseArmor
    {
        [Constructible]
        public WoodlandLegs() : base(0x2B6B) => Weight = 8.0;

        public WoodlandLegs(Serial serial) : base(serial)
        {
        }

        public override int BasePhysicalResistance => 5;
        public override int BaseFireResistance => 3;
        public override int BaseColdResistance => 2;
        public override int BasePoisonResistance => 3;
        public override int BaseEnergyResistance => 2;

        public override int InitMinHits => 50;
        public override int InitMaxHits => 65;

        public override int AosStrReq => 90;
        public override int OldStrReq => 90;

        public override int ArmorBase => 40;

        public override ArmorMaterialType MaterialType => ArmorMaterialType.Plate;
        public override Race RequiredRace => Race.Elf;

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadEncodedInt();
        }
    }
}
