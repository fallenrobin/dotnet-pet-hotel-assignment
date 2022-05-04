using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{

    public enum PetBreedType
    {
        Shepherd,
        Poodle,
        Beagle,
        Bulldog,
        Terrier,
        Boxer,
        Labrador,
        Retriever
    }
    public enum PetColorType
    {
        White,
        Black,
        Golden,
        Tricolor,
        Spotted
    }
    public class Pet
    {

        public int id { get; set; }

        public string name { get; set; }

        public PetBreedType breed { get; set; }

        public PetColorType color { get; set; }

        public DateTime checkedInAt { get; set; }

        [ForeignKey("petOwner")]
        public int petOwner_id { get; set; }
        
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetOwner petOwner { get; set; }


    }

}
