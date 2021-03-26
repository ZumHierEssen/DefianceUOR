namespace Server.Items
{
    public class DiseasedMachete : ElvenMachete
    {
        [Constructible]
        public DiseasedMachete() => WeaponAttributes.HitPoisonArea = 25;

        public DiseasedMachete(Serial serial) : base(serial)
        {
        }

        public override int LabelNumber => 1073536; // Diseased Machete

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