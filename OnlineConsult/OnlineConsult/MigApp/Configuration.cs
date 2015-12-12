namespace OnlineConsult.MigApp
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineConsult.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MigApp";
            ContextKey = "OnlineConsult.Models.ApplicationDbContext";
        }

        protected override void Seed(OnlineConsult.Models.ApplicationDbContext context)
        {
        
   

            context.Ailments.AddOrUpdate(
                i => i.ID,
                new ICD10
{
	 code = "A000",
	 description = "Cholera",
	 additional = "biovar cholerae"
},
new ICD10
{
	 code = "A001",
	 description = "Cholera",
	 additional = "biovar eltor"
},
new ICD10
{
	 code = "A009",
	 description = "Cholera",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0100",
	 description = "Typhoid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0101",
	 description = " Typhoid meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0102",
	 description = " Typhoid fever with heart involvement",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0103",
	 description = " Typhoid pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0104",
	 description = " Typhoid arthritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0105",
	 description = " Typhoid osteomyelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0109",
	 description = " Typhoid fever with other complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A011",
	 description = " Paratyphoid fever A",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A012",
	 description = " Paratyphoid fever B",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A013",
	 description = " Paratyphoid fever C",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A014",
	 description = "Paratyphoid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A020",
	 description = " Salmonella enteritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A021",
	 description = " Salmonella sepsis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0220",
	 description = "Localized",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0221",
	 description = " Salmonella meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0222",
	 description = " Salmonella pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0223",
	 description = " Salmonella arthritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0224",
	 description = " Salmonella osteomyelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0225",
	 description = " Salmonella pyelonephritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0229",
	 description = " Salmonella with other localized infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A028",
	 description = " Other specified salmonella infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A029",
	 description = "Salmonella",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A030",
	 description = " Shigellosis due to Shigella dysenteriae",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A031",
	 description = " Shigellosis due to Shigella flexneri",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A032",
	 description = " Shigellosis due to Shigella boydii",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A033",
	 description = " Shigellosis due to Shigella sonnei",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A038",
	 description = " Other shigellosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A039",
	 description = "Shigellosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A040",
	 description = " Enteropathogenic Escherichia coli infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A041",
	 description = " Enterotoxigenic Escherichia coli infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A042",
	 description = " Enteroinvasive Escherichia coli infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A043",
	 description = " Enterohemorrhagic Escherichia coli infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A044",
	 description = " Other intestinal Escherichia coli infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A045",
	 description = " Campylobacter enteritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A046",
	 description = " Enteritis due to Yersinia enterocolitica",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A047",
	 description = " Enterocolitis due to Clostridium difficile",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A048",
	 description = " Other specified bacterial intestinal infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A049",
	 description = "Bacterial",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A050",
	 description = " Foodborne staphylococcal intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A051",
	 description = " Botulism food poisoning",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A052",
	 description = " Foodborne Clostridium perfringens [Clostridium welchii] intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A053",
	 description = " Foodborne Vibrio parahaemolyticus intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A054",
	 description = " Foodborne Bacillus cereus intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A055",
	 description = " Foodborne Vibrio vulnificus intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A058",
	 description = " Other specified bacterial foodborne intoxications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A059",
	 description = "Bacterial",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A060",
	 description = " Acute amebic dysentery",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A061",
	 description = " Chronic intestinal amebiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A062",
	 description = " Amebic nondysenteric colitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A063",
	 description = " Ameboma of intestine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A064",
	 description = " Amebic liver abscess",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A065",
	 description = " Amebic lung abscess",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A066",
	 description = " Amebic brain abscess",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A067",
	 description = " Cutaneous amebiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0681",
	 description = " Amebic cystitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0682",
	 description = " Other amebic genitourinary infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A0689",
	 description = " Other amebic infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A069",
	 description = "Amebiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A070",
	 description = " Balantidiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A071",
	 description = " Giardiasis [lambliasis]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A072",
	 description = " Cryptosporidiosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A073",
	 description = " Isosporiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A074",
	 description = " Cyclosporiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A078",
	 description = " Other specified protozoal intestinal diseases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A079",
	 description = "Protozoal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A080",
	 description = " Rotaviral enteritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A081",
	 description = " Acute gastroenteropathy due to Norwalk agent",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A082",
	 description = " Adenoviral enteritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A083",
	 description = " Other viral enteritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A084",
	 description = "Viral",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A088",
	 description = " Other specified intestinal infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A09",
	 description = "Infectious",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A150",
	 description = " Tuberculosis of lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A154",
	 description = " Tuberculosis of intrathoracic lymph nodes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A155",
	 description = "Tuberculosis",
	 additional = "trachea and bronchus"
},
new ICD10
{
	 code = "A156",
	 description = " Tuberculous pleurisy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A157",
	 description = " Primary respiratory tuberculosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A158",
	 description = " Other respiratory tuberculosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A159",
	 description = " Respiratory tuberculosis unspecified",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A170",
	 description = " Tuberculous meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A171",
	 description = " Meningeal tuberculoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1781",
	 description = " Tuberculoma of brain and spinal cord",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1782",
	 description = " Tuberculous meningoencephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1783",
	 description = " Tuberculous neuritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1789",
	 description = " Other tuberculosis of nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A179",
	 description = "Tuberculosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1801",
	 description = " Tuberculosis of spine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1802",
	 description = " Tuberculous arthritis of other joints",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1803",
	 description = " Tuberculosis of other bones",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1809",
	 description = " Other musculoskeletal tuberculosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1810",
	 description = "Tuberculosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1811",
	 description = " Tuberculosis of kidney and ureter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1812",
	 description = " Tuberculosis of bladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1813",
	 description = " Tuberculosis of other urinary organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1814",
	 description = " Tuberculosis of prostate",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1815",
	 description = " Tuberculosis of other male genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1816",
	 description = " Tuberculosis of cervix",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1817",
	 description = " Tuberculous female pelvic inflammatory disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1818",
	 description = " Tuberculosis of other female genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A182",
	 description = " Tuberculous peripheral lymphadenopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1831",
	 description = " Tuberculous peritonitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1832",
	 description = " Tuberculous enteritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1839",
	 description = " Retroperitoneal tuberculosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A184",
	 description = " Tuberculosis of skin and subcutaneous tissue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1850",
	 description = "Tuberculosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1851",
	 description = " Tuberculous episcleritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1852",
	 description = " Tuberculous keratitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1853",
	 description = " Tuberculous chorioretinitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1854",
	 description = " Tuberculous iridocyclitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1859",
	 description = " Other tuberculosis of eye",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A186",
	 description = " Tuberculosis of (inner) (middle) ear",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A187",
	 description = " Tuberculosis of adrenal glands",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1881",
	 description = " Tuberculosis of thyroid gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1882",
	 description = " Tuberculosis of other endocrine glands",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1883",
	 description = "Tuberculosis",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "A1884",
	 description = " Tuberculosis of heart",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1885",
	 description = " Tuberculosis of spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A1889",
	 description = " Tuberculosis of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A190",
	 description = " Acute miliary tuberculosis of a single specified site",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A191",
	 description = " Acute miliary tuberculosis of multiple sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A192",
	 description = "Acute",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A198",
	 description = " Other miliary tuberculosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A199",
	 description = "Miliary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A200",
	 description = " Bubonic plague",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A201",
	 description = " Cellulocutaneous plague",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A202",
	 description = " Pneumonic plague",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A203",
	 description = " Plague meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A207",
	 description = " Septicemic plague",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A208",
	 description = " Other forms of plague",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A209",
	 description = "Plague",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A210",
	 description = " Ulceroglandular tularemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A211",
	 description = " Oculoglandular tularemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A212",
	 description = " Pulmonary tularemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A213",
	 description = " Gastrointestinal tularemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A217",
	 description = " Generalized tularemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A218",
	 description = " Other forms of tularemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A219",
	 description = "Tularemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A220",
	 description = " Cutaneous anthrax",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A221",
	 description = " Pulmonary anthrax",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A222",
	 description = " Gastrointestinal anthrax",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A227",
	 description = " Anthrax sepsis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A228",
	 description = " Other forms of anthrax",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A229",
	 description = "Anthrax",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A230",
	 description = " Brucellosis due to Brucella melitensis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A231",
	 description = " Brucellosis due to Brucella abortus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A232",
	 description = " Brucellosis due to Brucella suis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A233",
	 description = " Brucellosis due to Brucella canis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A238",
	 description = " Other brucellosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A239",
	 description = "Brucellosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A240",
	 description = " Glanders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A241",
	 description = " Acute and fulminating melioidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A242",
	 description = " Subacute and chronic melioidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A243",
	 description = " Other melioidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A249",
	 description = "Melioidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A250",
	 description = " Spirillosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A251",
	 description = " Streptobacillosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A259",
	 description = "Rat-bite",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A260",
	 description = " Cutaneous erysipeloid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A267",
	 description = " Erysipelothrix sepsis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A268",
	 description = " Other forms of erysipeloid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A269",
	 description = "Erysipeloid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A270",
	 description = " Leptospirosis icterohemorrhagica",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A2781",
	 description = " Aseptic meningitis in leptospirosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A2789",
	 description = " Other forms of leptospirosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A279",
	 description = "Leptospirosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A280",
	 description = " Pasteurellosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A281",
	 description = " Cat-scratch disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A282",
	 description = " Extraintestinal yersiniosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A288",
	 description = "Other",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "A289",
	 description = "Zoonotic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A300",
	 description = " Indeterminate leprosy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A301",
	 description = " Tuberculoid leprosy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A302",
	 description = " Borderline tuberculoid leprosy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A303",
	 description = " Borderline leprosy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A304",
	 description = " Borderline lepromatous leprosy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A305",
	 description = " Lepromatous leprosy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A308",
	 description = " Other forms of leprosy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A309",
	 description = "Leprosy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A310",
	 description = " Pulmonary mycobacterial infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A311",
	 description = " Cutaneous mycobacterial infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A312",
	 description = " Disseminated mycobacterium avium-intracellulare complex (DMAC)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A318",
	 description = " Other mycobacterial infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A319",
	 description = "Mycobacterial",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A320",
	 description = " Cutaneous listeriosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3211",
	 description = " Listerial meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3212",
	 description = " Listerial meningoencephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A327",
	 description = " Listerial sepsis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3281",
	 description = " Oculoglandular listeriosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3282",
	 description = " Listerial endocarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3289",
	 description = " Other forms of listeriosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A329",
	 description = "Listeriosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A33",
	 description = " Tetanus neonatorum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A34",
	 description = " Obstetrical tetanus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A35",
	 description = " Other tetanus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A360",
	 description = " Pharyngeal diphtheria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A361",
	 description = " Nasopharyngeal diphtheria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A362",
	 description = " Laryngeal diphtheria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A363",
	 description = " Cutaneous diphtheria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3681",
	 description = " Diphtheritic cardiomyopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3682",
	 description = " Diphtheritic radiculomyelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3683",
	 description = " Diphtheritic polyneuritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3684",
	 description = " Diphtheritic tubulo-interstitial nephropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3685",
	 description = " Diphtheritic cystitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3686",
	 description = " Diphtheritic conjunctivitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3689",
	 description = " Other diphtheritic complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A369",
	 description = "Diphtheria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3700",
	 description = " Whooping cough due to Bordetella pertussis without pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3701",
	 description = " Whooping cough due to Bordetella pertussis with pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3710",
	 description = " Whooping cough due to Bordetella parapertussis without pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3711",
	 description = " Whooping cough due to Bordetella parapertussis with pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3780",
	 description = " Whooping cough due to other Bordetella species without pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3781",
	 description = " Whooping cough due to other Bordetella species with pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3790",
	 description = "Whooping",
	 additional = "unspecified species without pneumonia"
},
new ICD10
{
	 code = "A3791",
	 description = "Whooping",
	 additional = "unspecified species with pneumonia"
},
new ICD10
{
	 code = "A380",
	 description = " Scarlet fever with otitis media",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A381",
	 description = " Scarlet fever with myocarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A388",
	 description = " Scarlet fever with other complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A389",
	 description = "Scarlet",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "A390",
	 description = " Meningococcal meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A391",
	 description = " Waterhouse-Friderichsen syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A392",
	 description = " Acute meningococcemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A393",
	 description = " Chronic meningococcemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A394",
	 description = "Meningococcemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3950",
	 description = "Meningococcal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3951",
	 description = " Meningococcal endocarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3952",
	 description = " Meningococcal myocarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3953",
	 description = " Meningococcal pericarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3981",
	 description = " Meningococcal encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3982",
	 description = " Meningococcal retrobulbar neuritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3983",
	 description = " Meningococcal arthritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3984",
	 description = " Postmeningococcal arthritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A3989",
	 description = " Other meningococcal infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A399",
	 description = "Meningococcal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A400",
	 description = "Sepsis",
	 additional = "group A"
},
new ICD10
{
	 code = "A401",
	 description = "Sepsis",
	 additional = "group B"
},
new ICD10
{
	 code = "A403",
	 description = " Sepsis due to Streptococcus pneumoniae",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A408",
	 description = " Other streptococcal sepsis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A409",
	 description = "Streptococcal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A410",
	 description = " Sepsis due to Staphylococcus aureus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A411",
	 description = " Sepsis due to other specified staphylococcus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A412",
	 description = " Sepsis due to unspecified staphylococcus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A413",
	 description = " Sepsis due to Hemophilus influenzae",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A414",
	 description = " Sepsis due to anaerobes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A4150",
	 description = "Gram-negative",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A4151",
	 description = " Sepsis due to Escherichia coli [E. coli]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A4152",
	 description = " Sepsis due to Pseudomonas",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A4153",
	 description = " Sepsis due to Serratia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A4159",
	 description = " Other Gram-negative sepsis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A4181",
	 description = " Sepsis due to Enterococcus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A4189",
	 description = " Other specified sepsis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A419",
	 description = "Sepsis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A420",
	 description = " Pulmonary actinomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A421",
	 description = " Abdominal actinomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A422",
	 description = " Cervicofacial actinomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A427",
	 description = " Actinomycotic sepsis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A4281",
	 description = " Actinomycotic meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A4282",
	 description = " Actinomycotic encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A4289",
	 description = " Other forms of actinomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A429",
	 description = "Actinomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A430",
	 description = " Pulmonary nocardiosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A431",
	 description = " Cutaneous nocardiosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A438",
	 description = " Other forms of nocardiosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A439",
	 description = "Nocardiosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A440",
	 description = " Systemic bartonellosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A441",
	 description = " Cutaneous and mucocutaneous bartonellosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A448",
	 description = " Other forms of bartonellosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A449",
	 description = "Bartonellosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A46",
	 description = " Erysipelas",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A480",
	 description = " Gas gangrene",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A481",
	 description = " Legionnaires' disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A482",
	 description = " Nonpneumonic Legionnaires' disease [Pontiac fever]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A483",
	 description = " Toxic shock syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A484",
	 description = " Brazilian purpuric fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A4851",
	 description = " Infant botulism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A4852",
	 description = " Wound botulism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A488",
	 description = " Other specified bacterial diseases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A490",
	 description = "Staphylococcal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A491",
	 description = "Streptococcal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A492",
	 description = "Hemophilus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A493",
	 description = "Mycoplasma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A498",
	 description = " Other bacterial infections of unspecified site",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A499",
	 description = "Bacterial",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5001",
	 description = " Early congenital syphilitic oculopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5002",
	 description = " Early congenital syphilitic osteochondropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5003",
	 description = " Early congenital syphilitic pharyngitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5004",
	 description = " Early congenital syphilitic pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5005",
	 description = " Early congenital syphilitic rhinitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5006",
	 description = " Early cutaneous congenital syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5007",
	 description = " Early mucocutaneous congenital syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5008",
	 description = " Early visceral congenital syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5009",
	 description = "Other",
	 additional = "symptomatic"
},
new ICD10
{
	 code = "A501",
	 description = "Early",
	 additional = "latent"
},
new ICD10
{
	 code = "A502",
	 description = "Early",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5030",
	 description = "Late",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5031",
	 description = " Late congenital syphilitic interstitial keratitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5032",
	 description = " Late congenital syphilitic chorioretinitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5039",
	 description = " Other late congenital syphilitic oculopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5040",
	 description = "Late",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5041",
	 description = " Late congenital syphilitic meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5042",
	 description = " Late congenital syphilitic encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5043",
	 description = " Late congenital syphilitic polyneuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5044",
	 description = " Late congenital syphilitic optic nerve atrophy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5045",
	 description = " Juvenile general paresis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5049",
	 description = " Other late congenital neurosyphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5051",
	 description = " Clutton's joints",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5052",
	 description = " Hutchinson's teeth",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5053",
	 description = " Hutchinson's triad",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5054",
	 description = " Late congenital cardiovascular syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5055",
	 description = " Late congenital syphilitic arthropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5056",
	 description = " Late congenital syphilitic osteochondropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5057",
	 description = " Syphilitic saddle nose",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5059",
	 description = "Other",
	 additional = "symptomatic"
},
new ICD10
{
	 code = "A506",
	 description = "Late",
	 additional = "latent"
},
new ICD10
{
	 code = "A507",
	 description = "Late",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A509",
	 description = "Congenital",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A510",
	 description = " Primary genital syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A511",
	 description = " Primary anal syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A512",
	 description = " Primary syphilis of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5131",
	 description = " Condyloma latum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5132",
	 description = " Syphilitic alopecia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5139",
	 description = " Other secondary syphilis of skin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5141",
	 description = " Secondary syphilitic meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5142",
	 description = " Secondary syphilitic female pelvic disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5143",
	 description = " Secondary syphilitic oculopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5144",
	 description = " Secondary syphilitic nephritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5145",
	 description = " Secondary syphilitic hepatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5146",
	 description = " Secondary syphilitic osteopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5149",
	 description = " Other secondary syphilitic conditions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A515",
	 description = "Early",
	 additional = "latent"
},
new ICD10
{
	 code = "A519",
	 description = "Early",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5200",
	 description = "Cardiovascular",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5201",
	 description = " Syphilitic aneurysm of aorta",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5202",
	 description = " Syphilitic aortitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5203",
	 description = " Syphilitic endocarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5204",
	 description = " Syphilitic cerebral arteritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5205",
	 description = " Other cerebrovascular syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5206",
	 description = " Other syphilitic heart involvement",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5209",
	 description = " Other cardiovascular syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5210",
	 description = "Symptomatic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5211",
	 description = " Tabes dorsalis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5212",
	 description = " Other cerebrospinal syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5213",
	 description = " Late syphilitic meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5214",
	 description = " Late syphilitic encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5215",
	 description = " Late syphilitic neuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5216",
	 description = " Charcot's arthropathy (tabetic)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5217",
	 description = " General paresis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5219",
	 description = " Other symptomatic neurosyphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A522",
	 description = " Asymptomatic neurosyphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A523",
	 description = "Neurosyphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5271",
	 description = " Late syphilitic oculopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5272",
	 description = " Syphilis of lung and bronchus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5273",
	 description = " Symptomatic late syphilis of other respiratory organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5274",
	 description = " Syphilis of liver and other viscera",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5275",
	 description = " Syphilis of kidney and ureter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5276",
	 description = " Other genitourinary symptomatic late syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5277",
	 description = " Syphilis of bone and joint",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5278",
	 description = " Syphilis of other musculoskeletal tissue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5279",
	 description = " Other symptomatic late syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A528",
	 description = "Late",
	 additional = "latent"
},
new ICD10
{
	 code = "A529",
	 description = "Late",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A530",
	 description = "Latent",
	 additional = "unspecified as early or late"
},
new ICD10
{
	 code = "A539",
	 description = "Syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5400",
	 description = "Gonococcal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5401",
	 description = "Gonococcal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5402",
	 description = "Gonococcal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5403",
	 description = "Gonococcal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5409",
	 description = " Other gonococcal infection of lower genitourinary tract",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A541",
	 description = " Gonococcal infection of lower genitourinary tract with periurethral and accessory gland abscess",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5421",
	 description = " Gonococcal infection of kidney and ureter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5422",
	 description = " Gonococcal prostatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5423",
	 description = " Gonococcal infection of other male genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5424",
	 description = " Gonococcal female pelvic inflammatory disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5429",
	 description = " Other gonococcal genitourinary infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5430",
	 description = "Gonococcal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5431",
	 description = " Gonococcal conjunctivitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5432",
	 description = " Gonococcal iridocyclitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5433",
	 description = " Gonococcal keratitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5439",
	 description = " Other gonococcal eye infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5440",
	 description = "Gonococcal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5441",
	 description = " Gonococcal spondylopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5442",
	 description = " Gonococcal arthritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5443",
	 description = " Gonococcal osteomyelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5449",
	 description = " Gonococcal infection of other musculoskeletal tissue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A545",
	 description = " Gonococcal pharyngitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A546",
	 description = " Gonococcal infection of anus and rectum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5481",
	 description = " Gonococcal meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5482",
	 description = " Gonococcal brain abscess",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5483",
	 description = " Gonococcal heart infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5484",
	 description = " Gonococcal pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5485",
	 description = " Gonococcal peritonitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5486",
	 description = " Gonococcal sepsis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5489",
	 description = " Other gonococcal infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A549",
	 description = "Gonococcal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A55",
	 description = " Chlamydial lymphogranuloma (venereum)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5600",
	 description = "Chlamydial",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5601",
	 description = " Chlamydial cystitis and urethritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5602",
	 description = " Chlamydial vulvovaginitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5609",
	 description = " Other chlamydial infection of lower genitourinary tract",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5611",
	 description = " Chlamydial female pelvic inflammatory disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5619",
	 description = " Other chlamydial genitourinary infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A562",
	 description = "Chlamydial",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A563",
	 description = " Chlamydial infection of anus and rectum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A564",
	 description = " Chlamydial infection of pharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A568",
	 description = " Sexually transmitted chlamydial infection of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A57",
	 description = " Chancroid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A58",
	 description = " Granuloma inguinale",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5900",
	 description = "Urogenital",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5901",
	 description = " Trichomonal vulvovaginitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5902",
	 description = " Trichomonal prostatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5903",
	 description = " Trichomonal cystitis and urethritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A5909",
	 description = " Other urogenital trichomoniasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A598",
	 description = " Trichomoniasis of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A599",
	 description = "Trichomoniasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A6000",
	 description = "Herpesviral",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A6001",
	 description = " Herpesviral infection of penis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A6002",
	 description = " Herpesviral infection of other male genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A6003",
	 description = " Herpesviral cervicitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A6004",
	 description = " Herpesviral vulvovaginitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A6009",
	 description = " Herpesviral infection of other urogenital tract",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A601",
	 description = " Herpesviral infection of perianal skin and rectum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A609",
	 description = "Anogenital",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A630",
	 description = " Anogenital (venereal) warts",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A638",
	 description = " Other specified predominantly sexually transmitted diseases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A64",
	 description = " Unspecified sexually transmitted disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A65",
	 description = " Nonvenereal syphilis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A660",
	 description = " Initial lesions of yaws",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A661",
	 description = " Multiple papillomata and wet crab yaws",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A662",
	 description = " Other early skin lesions of yaws",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A663",
	 description = " Hyperkeratosis of yaws",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A664",
	 description = " Gummata and ulcers of yaws",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A665",
	 description = " Gangosa",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A666",
	 description = " Bone and joint lesions of yaws",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A667",
	 description = " Other manifestations of yaws",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A668",
	 description = " Latent yaws",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A669",
	 description = "Yaws",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A670",
	 description = " Primary lesions of pinta",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A671",
	 description = " Intermediate lesions of pinta",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A672",
	 description = " Late lesions of pinta",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A673",
	 description = " Mixed lesions of pinta",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A679",
	 description = "Pinta",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A680",
	 description = " Louse-borne relapsing fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A681",
	 description = " Tick-borne relapsing fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A689",
	 description = "Relapsing",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A690",
	 description = " Necrotizing ulcerative stomatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A691",
	 description = " Other Vincent's infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A6920",
	 description = "Lyme",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A6921",
	 description = " Meningitis due to Lyme disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A6922",
	 description = " Other neurologic disorders in Lyme disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A6923",
	 description = " Arthritis due to Lyme disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A6929",
	 description = " Other conditions associated with Lyme disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A698",
	 description = " Other specified spirochetal infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A699",
	 description = "Spirochetal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A70",
	 description = " Chlamydia psittaci infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A710",
	 description = " Initial stage of trachoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A711",
	 description = " Active stage of trachoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A719",
	 description = "Trachoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A740",
	 description = " Chlamydial conjunctivitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A7481",
	 description = " Chlamydial peritonitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A7489",
	 description = " Other chlamydial diseases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A749",
	 description = "Chlamydial",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A750",
	 description = " Epidemic louse-borne typhus fever due to Rickettsia prowazekii",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A751",
	 description = " Recrudescent typhus [Brill's disease]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A752",
	 description = " Typhus fever due to Rickettsia typhi",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A753",
	 description = " Typhus fever due to Rickettsia tsutsugamushi",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A759",
	 description = "Typhus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A770",
	 description = " Spotted fever due to Rickettsia rickettsii",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A771",
	 description = " Spotted fever due to Rickettsia conorii",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A772",
	 description = " Spotted fever due to Rickettsia siberica",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A773",
	 description = " Spotted fever due to Rickettsia australis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A7740",
	 description = "Ehrlichiosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A7741",
	 description = " Ehrlichiosis chafeensis [E. chafeensis]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A7749",
	 description = " Other ehrlichiosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A778",
	 description = " Other spotted fevers",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A779",
	 description = "Spotted",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A78",
	 description = " Q fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A790",
	 description = " Trench fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A791",
	 description = " Rickettsialpox due to Rickettsia akari",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A7981",
	 description = " Rickettsiosis due to Ehrlichia sennetsu",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A7989",
	 description = " Other specified rickettsioses",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A799",
	 description = "Rickettsiosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A800",
	 description = "Acute",
	 additional = "vaccine-associated"
},
new ICD10
{
	 code = "A801    Acute paralytic poliomyelitis",
	 description = "wild virus",
	 additional = "imported"
},
new ICD10
{
	 code = "A802    Acute paralytic poliomyelitis",
	 description = "wild virus",
	 additional = "indigenous"
},
new ICD10
{
	 code = "A8030",
	 description = "Acute",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A8039",
	 description = " Other acute paralytic poliomyelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A804",
	 description = " Acute nonparalytic poliomyelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A809",
	 description = "Acute",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A810",
	 description = " Creutzfeldt-Jakob disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A811",
	 description = " Subacute sclerosing panencephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A812",
	 description = " Progressive multifocal leukoencephalopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A818",
	 description = " Other atypical virus infections of central nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A819",
	 description = "Atypical",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A820",
	 description = " Sylvatic rabies",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A821",
	 description = " Urban rabies",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A829",
	 description = "Rabies",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A830",
	 description = " Japanese encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A831",
	 description = " Western equine encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A832",
	 description = " Eastern equine encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A833",
	 description = " St Louis encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A834",
	 description = " Australian encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A835",
	 description = " California encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A836",
	 description = " Rocio virus disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A838",
	 description = " Other mosquito-borne viral encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A839",
	 description = "Mosquito-borne",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A840",
	 description = " Far Eastern tick-borne encephalitis [Russian spring-summer encephalitis]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A841",
	 description = " Central European tick-borne encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A848",
	 description = " Other tick-borne viral encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A849",
	 description = "Tick-borne",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A850",
	 description = " Enteroviral encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A851",
	 description = " Adenoviral encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A852",
	 description = "Arthropod-borne",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A858",
	 description = " Other specified viral encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A86",
	 description = " Unspecified viral encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A870",
	 description = " Enteroviral meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A871",
	 description = " Adenoviral meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A872",
	 description = " Lymphocytic choriomeningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A878",
	 description = " Other viral meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A879",
	 description = "Viral",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A880",
	 description = " Enteroviral exanthematous fever [Boston exanthem]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A881",
	 description = " Epidemic vertigo",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A888",
	 description = " Other specified viral infections of central nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A89",
	 description = " Unspecified viral infection of central nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A90",
	 description = " Dengue fever [classical dengue]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A91",
	 description = " Dengue hemorrhagic fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A920",
	 description = " Chikungunya virus disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A921",
	 description = " O'nyong-nyong fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A922",
	 description = " Venezuelan equine fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A9230",
	 description = "West",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A9231",
	 description = " West Nile virus infection with encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A9232",
	 description = " West Nile virus infection with other neurologic manifestation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A9239",
	 description = " West Nile virus infection with other complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A924",
	 description = " Rift Valley fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A928",
	 description = " Other specified mosquito-borne viral fevers",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A929",
	 description = "Mosquito-borne",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A930",
	 description = " Oropouche virus disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A931",
	 description = " Sandfly fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A932",
	 description = " Colorado tick fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A938",
	 description = " Other specified arthropod-borne viral fevers",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A94",
	 description = " Unspecified arthropod-borne viral fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A950",
	 description = " Sylvatic yellow fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A951",
	 description = " Urban yellow fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A959",
	 description = "Yellow",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A960",
	 description = " Junin hemorrhagic fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A961",
	 description = " Machupo hemorrhagic fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A962",
	 description = " Lassa fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A968",
	 description = " Other arenaviral hemorrhagic fevers",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A969",
	 description = "Arenaviral",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A980",
	 description = " Crimean-Congo hemorrhagic fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A981",
	 description = " Omsk hemorrhagic fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A982",
	 description = " Kyasanur Forest disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A983",
	 description = " Marburg virus disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A984",
	 description = " Ebola virus disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A985",
	 description = " Hemorrhagic fever with renal syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A988",
	 description = " Other specified viral hemorrhagic fevers",
	 additional = "unspecified"
},
new ICD10
{
	 code = "A99",
	 description = " Unspecified viral hemorrhagic fever",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B000",
	 description = " Eczema herpeticum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B001",
	 description = " Herpesviral vesicular dermatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B002",
	 description = " Herpesviral gingivostomatitis and pharyngotonsillitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B003",
	 description = " Herpesviral meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B004",
	 description = " Herpesviral encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0050",
	 description = "Herpesviral",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0051",
	 description = " Herpesviral iridocyclitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0052",
	 description = " Herpesviral keratitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0053",
	 description = " Herpesviral conjunctivitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0059",
	 description = " Other herpesviral disease of eye",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B007",
	 description = " Disseminated herpesviral disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0081",
	 description = " Herpesviral hepatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0082",
	 description = " Herpes simplex myelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0089",
	 description = " Other herpesviral infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B009",
	 description = "Herpesviral",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B010",
	 description = " Varicella meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0111",
	 description = " Varicella encephalitis and encephalomyelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0112",
	 description = " Varicella myelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B012",
	 description = " Varicella pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0181",
	 description = " Varicella keratitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0189",
	 description = " Other varicella complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B019",
	 description = " Varicella without complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B020",
	 description = " Zoster encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B021",
	 description = " Zoster meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0221",
	 description = " Postherpetic geniculate ganglionitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0222",
	 description = " Postherpetic trigeminal neuralgia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0223",
	 description = " Postherpetic polyneuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0224",
	 description = " Postherpetic myelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0229",
	 description = " Other postherpetic nervous system involvement",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0230",
	 description = "Zoster",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0231",
	 description = " Zoster conjunctivitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0232",
	 description = " Zoster iridocyclitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0233",
	 description = " Zoster keratitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0234",
	 description = " Zoster scleritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0239",
	 description = " Other herpes zoster eye disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B027",
	 description = " Disseminated zoster",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B028",
	 description = " Zoster with other complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B029",
	 description = " Zoster without complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B03",
	 description = " Smallpox",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B04",
	 description = " Monkeypox",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B050",
	 description = " Measles complicated by encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B051",
	 description = " Measles complicated by meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B052",
	 description = " Measles complicated by pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B053",
	 description = " Measles complicated by otitis media",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B054",
	 description = " Measles with intestinal complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0581",
	 description = " Measles keratitis and keratoconjunctivitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0589",
	 description = " Other measles complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B059",
	 description = " Measles without complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0600",
	 description = "Rubella",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0601",
	 description = " Rubella encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0602",
	 description = " Rubella meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0609",
	 description = " Other neurological complications of rubella",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0681",
	 description = " Rubella pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0682",
	 description = " Rubella arthritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0689",
	 description = " Other rubella complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B069",
	 description = " Rubella without complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B07",
	 description = " Viral warts",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B080",
	 description = " Other orthopoxvirus infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B081",
	 description = " Molluscum contagiosum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0820",
	 description = "Exanthema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0821",
	 description = " Exanthema subitum [sixth disease] due to human herpesvirus 6",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B0822",
	 description = " Exanthema subitum [sixth disease] due to human herpesvirus 7",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B083",
	 description = " Erythema infectiosum [fifth disease]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B084",
	 description = " Enteroviral vesicular stomatitis with exanthem",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B085",
	 description = " Enteroviral vesicular pharyngitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B088",
	 description = " Other specified viral infections characterized by skin and mucous membrane lesions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B09",
	 description = " Unspecified viral infection characterized by skin and mucous membrane lesions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B1001",
	 description = " Human herpesvirus 6 encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B1009",
	 description = " Other human herpesvirus encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B1081",
	 description = " Human herpesvirus 6 infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B1082",
	 description = " Human herpesvirus 7 infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B1089",
	 description = " Other human herpesvirus infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B150",
	 description = " Hepatitis A with hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B159",
	 description = " Hepatitis A without hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B160",
	 description = " Acute hepatitis B with delta-agent with hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B161",
	 description = " Acute hepatitis B with delta-agent without hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B162",
	 description = " Acute hepatitis B without delta-agent with hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B169",
	 description = " Acute hepatitis B without delta-agent and without hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B170",
	 description = " Acute delta-(super) infection of hepatitis B carrier",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B1710",
	 description = " Acute hepatitis C without hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B1711",
	 description = " Acute hepatitis C with hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B172",
	 description = " Acute hepatitis E",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B178",
	 description = " Other specified acute viral hepatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B179",
	 description = "Acute",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B180",
	 description = " Chronic viral hepatitis B with delta-agent",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B181",
	 description = " Chronic viral hepatitis B without delta-agent",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B182",
	 description = " Chronic viral hepatitis C",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B188",
	 description = " Other chronic viral hepatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B189",
	 description = "Chronic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B190",
	 description = " Unspecified viral hepatitis with hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B1910",
	 description = " Unspecified viral hepatitis B without hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B1911",
	 description = " Unspecified viral hepatitis B with hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B1920",
	 description = " Unspecified viral hepatitis C without hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B1921",
	 description = " Unspecified viral hepatitis C with hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B199",
	 description = " Unspecified viral hepatitis without hepatic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B20",
	 description = " Human immunodeficiency virus [HIV] disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B250",
	 description = " Cytomegaloviral pneumonitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B251",
	 description = " Cytomegaloviral hepatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B252",
	 description = " Cytomegaloviral pancreatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B258",
	 description = " Other cytomegaloviral diseases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B259",
	 description = "Cytomegaloviral",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B260",
	 description = " Mumps orchitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B261",
	 description = " Mumps meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B262",
	 description = " Mumps encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B263",
	 description = " Mumps pancreatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2681",
	 description = " Mumps hepatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2682",
	 description = " Mumps myocarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2683",
	 description = " Mumps nephritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2684",
	 description = " Mumps polyneuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2685",
	 description = " Mumps arthritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2689",
	 description = " Other mumps complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B269",
	 description = " Mumps without complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2700",
	 description = " Gammaherpesviral mononucleosis without complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2701",
	 description = " Gammaherpesviral mononucleosis with polyneuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2702",
	 description = " Gammaherpesviral mononucleosis with meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2709",
	 description = " Gammaherpesviral mononucleosis with other complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2710",
	 description = " Cytomegaloviral mononucleosis without complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2711",
	 description = " Cytomegaloviral mononucleosis with polyneuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2712",
	 description = " Cytomegaloviral mononucleosis with meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2719",
	 description = " Cytomegaloviral mononucleosis with other complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2780",
	 description = " Other infectious mononucleosis without complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2781",
	 description = " Other infectious mononucleosis with polyneuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2782",
	 description = " Other infectious mononucleosis with meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2789",
	 description = " Other infectious mononucleosis with other complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B2790",
	 description = "Infectious",
	 additional = "unspecified without complication"
},
new ICD10
{
	 code = "B2791",
	 description = "Infectious",
	 additional = "unspecified with polyneuropathy"
},
new ICD10
{
	 code = "B2792",
	 description = "Infectious",
	 additional = "unspecified with meningitis"
},
new ICD10
{
	 code = "B2799",
	 description = "Infectious",
	 additional = "unspecified with other complication"
},
new ICD10
{
	 code = "B300",
	 description = " Keratoconjunctivitis due to adenovirus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B301",
	 description = " Conjunctivitis due to adenovirus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B302",
	 description = " Viral pharyngoconjunctivitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B303",
	 description = " Acute epidemic hemorrhagic conjunctivitis (enteroviral)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B308",
	 description = " Other viral conjunctivitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B309",
	 description = "Viral",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B330",
	 description = " Epidemic myalgia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B331",
	 description = " Ross River disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3320",
	 description = "Viral",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3321",
	 description = " Viral endocarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3322",
	 description = " Viral myocarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3323",
	 description = " Viral pericarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3324",
	 description = " Viral cardiomyopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B333",
	 description = "Retrovirus",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "B334",
	 description = " Hantavirus (cardio)-pulmonary syndrome [HPS] [HCPS]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B338",
	 description = " Other specified viral diseases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B340",
	 description = "Adenovirus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B341",
	 description = "Enterovirus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B342",
	 description = "Coronavirus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B343",
	 description = "Parvovirus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B344",
	 description = "Papovavirus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B348",
	 description = " Other viral infections of unspecified site",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B349",
	 description = "Viral",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B350",
	 description = " Tinea barbae and tinea capitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B351",
	 description = " Tinea unguium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B352",
	 description = " Tinea manuum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B353",
	 description = " Tinea pedis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B354",
	 description = " Tinea corporis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B355",
	 description = " Tinea imbricata",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B356",
	 description = " Tinea cruris",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B358",
	 description = " Other dermatophytoses",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B359",
	 description = "Dermatophytosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B360",
	 description = " Pityriasis versicolor",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B361",
	 description = " Tinea nigra",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B362",
	 description = " White piedra",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B363",
	 description = " Black piedra",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B368",
	 description = " Other specified superficial mycoses",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B369",
	 description = "Superficial",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B370",
	 description = " Candidal stomatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B371",
	 description = " Pulmonary candidiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B372",
	 description = " Candidiasis of skin and nail",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B373",
	 description = " Candidiasis of vulva and vagina",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3741",
	 description = " Candidal cystitis and urethritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3742",
	 description = " Candidal balanitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3749",
	 description = " Other urogenital candidiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B375",
	 description = " Candidal meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B376",
	 description = " Candidal endocarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B377",
	 description = " Candidal sepsis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3781",
	 description = " Candidal esophagitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3782",
	 description = " Candidal enteritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3783",
	 description = " Candidal cheilitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3784",
	 description = " Candidal otitis externa",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3789",
	 description = " Other sites of candidiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B379",
	 description = "Candidiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B380",
	 description = " Acute pulmonary coccidioidomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B381",
	 description = " Chronic pulmonary coccidioidomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B382",
	 description = "Pulmonary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B383",
	 description = " Cutaneous coccidioidomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B384",
	 description = " Coccidioidomycosis meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B387",
	 description = " Disseminated coccidioidomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3881",
	 description = " Prostatic coccidioidomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B3889",
	 description = " Other forms of coccidioidomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B389",
	 description = "Coccidioidomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B390",
	 description = " Acute pulmonary histoplasmosis capsulati",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B391",
	 description = " Chronic pulmonary histoplasmosis capsulati",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B392",
	 description = "Pulmonary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B393",
	 description = " Disseminated histoplasmosis capsulati",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B394",
	 description = "Histoplasmosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B395",
	 description = " Histoplasmosis duboisii",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B399",
	 description = "Histoplasmosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B400",
	 description = " Acute pulmonary blastomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B401",
	 description = " Chronic pulmonary blastomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B402",
	 description = "Pulmonary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B403",
	 description = " Cutaneous blastomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B407",
	 description = " Disseminated blastomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B4081",
	 description = " Blastomycotic meningoencephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B4089",
	 description = " Other forms of blastomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B409",
	 description = "Blastomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B410",
	 description = " Pulmonary paracoccidioidomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B417",
	 description = " Disseminated paracoccidioidomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B418",
	 description = " Other forms of paracoccidioidomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B419",
	 description = "Paracoccidioidomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B420",
	 description = " Pulmonary sporotrichosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B421",
	 description = " Lymphocutaneous sporotrichosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B427",
	 description = " Disseminated sporotrichosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B4281",
	 description = " Cerebral sporotrichosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B4282",
	 description = " Sporotrichosis arthritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B4289",
	 description = " Other forms of sporotrichosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B429",
	 description = "Sporotrichosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B430",
	 description = " Cutaneous chromomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B431",
	 description = " Pheomycotic brain abscess",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B432",
	 description = " Subcutaneous pheomycotic abscess and cyst",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B438",
	 description = " Other forms of chromomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B439",
	 description = "Chromomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B440",
	 description = " Invasive pulmonary aspergillosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B441",
	 description = " Other pulmonary aspergillosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B442",
	 description = " Tonsillar aspergillosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B447",
	 description = " Disseminated aspergillosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B4481",
	 description = " Allergic bronchopulmonary aspergillosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B4489",
	 description = " Other forms of aspergillosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B449",
	 description = "Aspergillosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B450",
	 description = " Pulmonary cryptococcosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B451",
	 description = " Cerebral cryptococcosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B452",
	 description = " Cutaneous cryptococcosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B453",
	 description = " Osseous cryptococcosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B457",
	 description = " Disseminated cryptococcosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B458",
	 description = " Other forms of cryptococcosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B459",
	 description = "Cryptococcosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B460",
	 description = " Pulmonary mucormycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B461",
	 description = " Rhinocerebral mucormycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B462",
	 description = " Gastrointestinal mucormycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B463",
	 description = " Cutaneous mucormycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B464",
	 description = " Disseminated mucormycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B465",
	 description = "Mucormycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B468",
	 description = " Other zygomycoses",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B469",
	 description = "Zygomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B470",
	 description = " Eumycetoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B471",
	 description = " Actinomycetoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B479",
	 description = "Mycetoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B480",
	 description = " Lobomycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B481",
	 description = " Rhinosporidiosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B482",
	 description = " Allescheriasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B483",
	 description = " Geotrichosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B484",
	 description = " Penicillosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B488",
	 description = " Other specified mycoses",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B49",
	 description = " Unspecified mycosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B500",
	 description = " Plasmodium falciparum malaria with cerebral complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B508",
	 description = " Other severe and complicated Plasmodium falciparum malaria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B509",
	 description = "Plasmodium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B510",
	 description = " Plasmodium vivax malaria with rupture of spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B518",
	 description = " Plasmodium vivax malaria with other complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B519",
	 description = " Plasmodium vivax malaria without complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B520",
	 description = " Plasmodium malariae malaria with nephropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B528",
	 description = " Plasmodium malariae malaria with other complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B529",
	 description = " Plasmodium malariae malaria without complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B530",
	 description = " Plasmodium ovale malaria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B531",
	 description = " Malaria due to simian plasmodia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B538",
	 description = "Other",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "B54",
	 description = " Unspecified malaria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B550",
	 description = " Visceral leishmaniasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B551",
	 description = " Cutaneous leishmaniasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B552",
	 description = " Mucocutaneous leishmaniasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B559",
	 description = "Leishmaniasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B560",
	 description = " Gambiense trypanosomiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B561",
	 description = " Rhodesiense trypanosomiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B569",
	 description = "African",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B570",
	 description = " Acute Chagas' disease with heart involvement",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B571",
	 description = " Acute Chagas' disease without heart involvement",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B572",
	 description = " Chagas' disease (chronic) with heart involvement",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5730",
	 description = "Chagas'",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5731",
	 description = " Megaesophagus in Chagas' disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5732",
	 description = " Megacolon in Chagas' disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5739",
	 description = " Other digestive system involvement in Chagas' disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5740",
	 description = "Chagas'",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5741",
	 description = " Meningitis in Chagas' disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5742",
	 description = " Meningoencephalitis in Chagas' disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5749",
	 description = " Other nervous system involvement in Chagas' disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B575",
	 description = " Chagas' disease (chronic) with other organ involvement",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5800",
	 description = "Toxoplasma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5801",
	 description = " Toxoplasma chorioretinitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5809",
	 description = " Other toxoplasma oculopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B581",
	 description = " Toxoplasma hepatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B582",
	 description = " Toxoplasma meningoencephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B583",
	 description = " Pulmonary toxoplasmosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5881",
	 description = " Toxoplasma myocarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5882",
	 description = " Toxoplasma myositis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5883",
	 description = " Toxoplasma tubulo-interstitial nephropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B5889",
	 description = " Toxoplasmosis with other organ involvement",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B589",
	 description = "Toxoplasmosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B59",
	 description = " Pneumocystosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B600",
	 description = " Babesiosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B6010",
	 description = "Acanthamebiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B6011",
	 description = " Meningoencephalitis due to Acanthamoeba (culbertsoni)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B6012",
	 description = " Conjunctivitis due to Acanthamoeba",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B6013",
	 description = " Keratoconjunctivitis due to Acanthamoeba",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B6019",
	 description = " Other acanthamebic disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B602",
	 description = " Naegleriasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B608",
	 description = " Other specified protozoal diseases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B64",
	 description = " Unspecified protozoal disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B650",
	 description = " Schistosomiasis due to Schistosoma haematobium [urinary schistosomiasis]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B651",
	 description = " Schistosomiasis due to Schistosoma mansoni [intestinal schistosomiasis]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B652",
	 description = " Schistosomiasis due to Schistosoma japonicum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B653",
	 description = " Cercarial dermatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B658",
	 description = " Other schistosomiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B659",
	 description = "Schistosomiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B660",
	 description = " Opisthorchiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B661",
	 description = " Clonorchiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B662",
	 description = " Dicroceliasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B663",
	 description = " Fascioliasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B664",
	 description = " Paragonimiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B665",
	 description = " Fasciolopsiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B668",
	 description = " Other specified fluke infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B669",
	 description = "Fluke",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B670",
	 description = " Echinococcus granulosus infection of liver",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B671",
	 description = " Echinococcus granulosus infection of lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B672",
	 description = " Echinococcus granulosus infection of bone",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B6731",
	 description = "Echinococcus",
	 additional = "thyroid gland"
},
new ICD10
{
	 code = "B6732",
	 description = "Echinococcus",
	 additional = "multiple sites"
},
new ICD10
{
	 code = "B6739",
	 description = "Echinococcus",
	 additional = "other sites"
},
new ICD10
{
	 code = "B674",
	 description = "Echinococcus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B675",
	 description = " Echinococcus multilocularis infection of liver",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B6761",
	 description = "Echinococcus",
	 additional = "multiple sites"
},
new ICD10
{
	 code = "B6769",
	 description = "Echinococcus",
	 additional = "other sites"
},
new ICD10
{
	 code = "B677",
	 description = "Echinococcus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B678    Echinococcosis",
	 description = "unspecified",
	 additional = "of liver"
},
new ICD10
{
	 code = "B6790",
	 description = "Echinococcosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B6799",
	 description = " Other echinococcosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B680",
	 description = " Taenia solium taeniasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B681",
	 description = " Taenia saginata taeniasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B689",
	 description = "Taeniasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B690",
	 description = " Cysticercosis of central nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B691",
	 description = " Cysticercosis of eye",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B6981",
	 description = " Myositis in cysticercosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B6989",
	 description = " Cysticercosis of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B699",
	 description = "Cysticercosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B700",
	 description = " Diphyllobothriasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B701",
	 description = " Sparganosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B710",
	 description = " Hymenolepiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B711",
	 description = " Dipylidiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B718",
	 description = " Other specified cestode infections",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B719",
	 description = "Cestode",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B72",
	 description = " Dracunculiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B7300",
	 description = "Onchocerciasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B7301",
	 description = " Onchocerciasis with endophthalmitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B7302",
	 description = " Onchocerciasis with glaucoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B7309",
	 description = " Onchocerciasis with other eye involvement",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B731",
	 description = " Onchocerciasis without eye disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B740",
	 description = " Filariasis due to Wuchereria bancrofti",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B741",
	 description = " Filariasis due to Brugia malayi",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B742",
	 description = " Filariasis due to Brugia timori",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B743",
	 description = " Loiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B744",
	 description = " Mansonelliasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B748",
	 description = " Other filariases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B749",
	 description = "Filariasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B75",
	 description = " Trichinellosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B760",
	 description = " Ancylostomiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B761",
	 description = " Necatoriasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B768",
	 description = " Other hookworm diseases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B769",
	 description = "Hookworm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B770",
	 description = " Ascariasis with intestinal complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B7781",
	 description = " Ascariasis pneumonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B7789",
	 description = " Ascariasis with other complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B779",
	 description = "Ascariasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B780",
	 description = " Intestinal strongyloidiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B781",
	 description = " Cutaneous strongyloidiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B787",
	 description = " Disseminated strongyloidiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B789",
	 description = "Strongyloidiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B79",
	 description = " Trichuriasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B80",
	 description = " Enterobiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B810",
	 description = " Anisakiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B811",
	 description = " Intestinal capillariasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B812",
	 description = " Trichostrongyliasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B813",
	 description = " Intestinal angiostrongyliasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B814",
	 description = " Mixed intestinal helminthiases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B818",
	 description = " Other specified intestinal helminthiases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B820",
	 description = "Intestinal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B829",
	 description = "Intestinal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B830",
	 description = " Visceral larva migrans",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B831",
	 description = " Gnathostomiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B832",
	 description = " Angiostrongyliasis due to Parastrongylus cantonensis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B833",
	 description = " Syngamiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B834",
	 description = " Internal hirudiniasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B838",
	 description = " Other specified helminthiases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B839",
	 description = "Helminthiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B850",
	 description = " Pediculosis due to Pediculus humanus capitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B851",
	 description = " Pediculosis due to Pediculus humanus corporis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B852",
	 description = "Pediculosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B853",
	 description = " Phthiriasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B854",
	 description = " Mixed pediculosis and phthiriasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B86",
	 description = " Scabies",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B870",
	 description = " Cutaneous myiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B871",
	 description = " Wound myiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B872",
	 description = " Ocular myiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B873",
	 description = " Nasopharyngeal myiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B874",
	 description = " Aural myiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B8781",
	 description = " Genitourinary myiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B8782",
	 description = " Intestinal myiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B8789",
	 description = " Myiasis of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B879",
	 description = "Myiasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B880",
	 description = " Other acariasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B881",
	 description = " Tungiasis [sandflea infestation]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B882",
	 description = " Other arthropod infestations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B883",
	 description = " External hirudiniasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B888",
	 description = " Other specified infestations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B889",
	 description = "Infestation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B89",
	 description = " Unspecified parasitic disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B900",
	 description = " Sequelae of central nervous system tuberculosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B901",
	 description = " Sequelae of genitourinary tuberculosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B902",
	 description = " Sequelae of tuberculosis of bones and joints",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B908",
	 description = " Sequelae of tuberculosis of other organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B909",
	 description = " Sequelae of respiratory and unspecified tuberculosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B91",
	 description = " Sequelae of poliomyelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B92",
	 description = " Sequelae of leprosy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B940",
	 description = " Sequelae of trachoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B941",
	 description = " Sequelae of viral encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B942",
	 description = " Sequelae of viral hepatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B948",
	 description = " Sequelae of other specified infectious and parasitic diseases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B949",
	 description = " Sequelae of unspecified infectious and parasitic disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B950    Streptococcus",
	 description = "group A",
	 additional = "as the cause of diseases classified elsewhere"
},
new ICD10
{
	 code = "B951    Streptococcus",
	 description = "group B",
	 additional = "as the cause of diseases classified elsewhere"
},
new ICD10
{
	 code = "B952",
	 description = " Enterococcus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B953",
	 description = " Streptococcus pneumoniae as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B954",
	 description = " Other streptococcus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B955",
	 description = " Unspecified streptococcus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B956",
	 description = " Staphylococcus aureus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B957",
	 description = " Other staphylococcus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B958",
	 description = " Unspecified staphylococcus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B960",
	 description = " Mycoplasma pneumoniae [M. pneumoniae] as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B961",
	 description = " Klebsiella pneumoniae [K. pneumoniae] as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B962",
	 description = " Escherichia coli [E. coli ] as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B963",
	 description = " Hemophilus influenzae [H. influenzae] as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B964",
	 description = " Proteus (mirabilis) (morganii) as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B965",
	 description = " Pseudomonas (aeruginosa) (mallei) (pseudomallei) as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B966",
	 description = " Bacteroides fragilis [B. fragilis] as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B967",
	 description = " Clostridium perfringens [C. perfringens] as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B9681",
	 description = " Helicobacter pylori [H. pylori] as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B9689",
	 description = " Other specified bacterial agents as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B970",
	 description = " Adenovirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B9710",
	 description = " Unspecified enterovirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B9711",
	 description = " Coxsackievirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B9712",
	 description = " Echovirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B9719",
	 description = " Other enterovirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B9721",
	 description = " SARS-associated coronavirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B9729",
	 description = " Other coronavirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B9730",
	 description = " Unspecified retrovirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B9731",
	 description = " Lentivirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B9732",
	 description = " Oncovirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B9733",
	 description = "Human",
	 additional = "type I [HTLV-I] as the cause of diseases classified elsewhere"
},
new ICD10
{
	 code = "B9734",
	 description = "Human",
	 additional = "type II [HTLV-II] as the cause of diseases classified elsewhere"
},
new ICD10
{
	 code = "B9735",
	 description = "Human",
	 additional = "type 2 [HIV 2] as the cause of diseases classified elsewhere"
},
new ICD10
{
	 code = "B9739",
	 description = " Other retrovirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B974",
	 description = " Respiratory syncytial virus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B975",
	 description = " Reovirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B976",
	 description = " Parvovirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B977",
	 description = " Papillomavirus as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B978",
	 description = " Other viral agents as the cause of diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B998",
	 description = " Other infectious disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "B999",
	 description = " Unspecified infectious disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C000",
	 description = " Malignant neoplasm of external upper lip",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C001",
	 description = " Malignant neoplasm of external lower lip",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C002",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C003",
	 description = "Malignant",
	 additional = "inner aspect"
},
new ICD10
{
	 code = "C004",
	 description = "Malignant",
	 additional = "inner aspect"
},
new ICD10
{
	 code = "C005    Malignant neoplasm of lip",
	 description = "unspecified",
	 additional = "inner aspect"
},
new ICD10
{
	 code = "C006",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C008",
	 description = " Malignant neoplasm of overlapping sites of lip",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C009",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C01",
	 description = " Malignant neoplasm of base of tongue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C020",
	 description = " Malignant neoplasm of dorsal surface of tongue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C021",
	 description = " Malignant neoplasm of border of tongue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C022",
	 description = " Malignant neoplasm of ventral surface of tongue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C023",
	 description = "Malignant",
	 additional = "part unspecified"
},
new ICD10
{
	 code = "C024",
	 description = " Malignant neoplasm of lingual tonsil",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C028",
	 description = " Malignant neoplasm of overlapping sites of tongue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C029",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C030",
	 description = " Malignant neoplasm of upper gum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C031",
	 description = " Malignant neoplasm of lower gum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C039",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C040",
	 description = " Malignant neoplasm of anterior floor of mouth",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C041",
	 description = " Malignant neoplasm of lateral floor of mouth",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C048",
	 description = " Malignant neoplasm of overlapping sites of floor of mouth",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C049",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C050",
	 description = " Malignant neoplasm of hard palate",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C051",
	 description = " Malignant neoplasm of soft palate",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C052",
	 description = " Malignant neoplasm of uvula",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C058",
	 description = " Malignant neoplasm of overlapping sites of palate",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C059",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C060",
	 description = " Malignant neoplasm of cheek mucosa",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C061",
	 description = " Malignant neoplasm of vestibule of mouth",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C062",
	 description = " Malignant neoplasm of retromolar area",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C0680",
	 description = " Malignant neoplasm of overlapping sites of unspecified parts of mouth",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C0689",
	 description = " Malignant neoplasm of overlapping sites of other parts of mouth",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C069",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C07",
	 description = " Malignant neoplasm of parotid gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C080",
	 description = " Malignant neoplasm of submandibular gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C081",
	 description = " Malignant neoplasm of sublingual gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C089",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C090",
	 description = " Malignant neoplasm of tonsillar fossa",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C091",
	 description = " Malignant neoplasm of tonsillar pillar (anterior) (posterior)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C098",
	 description = " Malignant neoplasm of overlapping sites of tonsil",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C099",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C100",
	 description = " Malignant neoplasm of vallecula",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C101",
	 description = " Malignant neoplasm of anterior surface of epiglottis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C102",
	 description = " Malignant neoplasm of lateral wall of oropharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C103",
	 description = " Malignant neoplasm of posterior wall of oropharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C104",
	 description = " Malignant neoplasm of branchial cleft",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C108",
	 description = " Malignant neoplasm of overlapping sites of oropharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C109",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C110",
	 description = " Malignant neoplasm of superior wall of nasopharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C111",
	 description = " Malignant neoplasm of posterior wall of nasopharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C112",
	 description = " Malignant neoplasm of lateral wall of nasopharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C113",
	 description = " Malignant neoplasm of anterior wall of nasopharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C118",
	 description = " Malignant neoplasm of overlapping sites of nasopharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C119",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C12",
	 description = " Malignant neoplasm of pyriform sinus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C130",
	 description = " Malignant neoplasm of postcricoid region",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C131",
	 description = "Malignant",
	 additional = "hypopharyngeal aspect"
},
new ICD10
{
	 code = "C132",
	 description = " Malignant neoplasm of posterior wall of hypopharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C138",
	 description = " Malignant neoplasm of overlapping sites of hypopharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C139",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C140",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C142",
	 description = " Malignant neoplasm of Waldeyer's ring",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C148",
	 description = "Malignant",
	 additional = "oral cavity and pharynx"
},
new ICD10
{
	 code = "C153",
	 description = " Malignant neoplasm of upper third of esophagus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C154",
	 description = " Malignant neoplasm of middle third of esophagus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C155",
	 description = " Malignant neoplasm of lower third of esophagus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C158",
	 description = " Malignant neoplasm of overlapping sites of esophagus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C159",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C160",
	 description = " Malignant neoplasm of cardia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C161",
	 description = " Malignant neoplasm of fundus of stomach",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C162",
	 description = " Malignant neoplasm of body of stomach",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C163",
	 description = " Malignant neoplasm of pyloric antrum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C164",
	 description = " Malignant neoplasm of pylorus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C165",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C166",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C168",
	 description = " Malignant neoplasm of overlapping sites of stomach",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C169",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C170",
	 description = " Malignant neoplasm of duodenum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C171",
	 description = " Malignant neoplasm of jejunum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C172",
	 description = " Malignant neoplasm of ileum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C173",
	 description = " Meckel's diverticulum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C178",
	 description = " Malignant neoplasm of overlapping sites of small intestine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C179",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C180",
	 description = " Malignant neoplasm of cecum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C181",
	 description = " Malignant neoplasm of appendix",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C182",
	 description = " Malignant neoplasm of ascending colon",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C183",
	 description = " Malignant neoplasm of hepatic flexure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C184",
	 description = " Malignant neoplasm of transverse colon",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C185",
	 description = " Malignant neoplasm of splenic flexure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C186",
	 description = " Malignant neoplasm of descending colon",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C187",
	 description = " Malignant neoplasm of sigmoid colon",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C188",
	 description = " Malignant neoplasm of overlapping sites of colon",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C189",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C19",
	 description = " Malignant neoplasm of rectosigmoid junction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C20",
	 description = " Malignant neoplasm of rectum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C210",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C211",
	 description = " Malignant neoplasm of anal canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C212",
	 description = " Malignant neoplasm of cloacogenic zone",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C218",
	 description = "Malignant",
	 additional = "anus and anal canal"
},
new ICD10
{
	 code = "C220",
	 description = " Liver cell carcinoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C221",
	 description = " Intrahepatic bile duct carcinoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C222",
	 description = " Hepatoblastoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C223",
	 description = " Angiosarcoma of liver",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C224",
	 description = " Other sarcomas of liver",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C227",
	 description = " Other specified carcinomas of liver",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C228    Malignant neoplasm of liver",
	 description = "primary",
	 additional = "unspecified as to type"
},
new ICD10
{
	 code = "C229",
	 description = "Malignant",
	 additional = "not specified as primary or secondary"
},
new ICD10
{
	 code = "C23",
	 description = " Malignant neoplasm of gallbladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C240",
	 description = " Malignant neoplasm of extrahepatic bile duct",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C241",
	 description = " Malignant neoplasm of ampulla of Vater",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C248",
	 description = " Malignant neoplasm of overlapping sites of biliary tract",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C249",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C250",
	 description = " Malignant neoplasm of head of pancreas",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C251",
	 description = " Malignant neoplasm of body of pancreas",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C252",
	 description = " Malignant neoplasm of tail of pancreas",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C253",
	 description = " Malignant neoplasm of pancreatic duct",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C254",
	 description = " Malignant neoplasm of endocrine pancreas",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C257",
	 description = " Malignant neoplasm of other parts of pancreas",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C258",
	 description = " Malignant neoplasm of overlapping sites of pancreas",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C259",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C260",
	 description = "Malignant",
	 additional = "part unspecified"
},
new ICD10
{
	 code = "C261",
	 description = " Malignant neoplasm of spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C269",
	 description = " Malignant neoplasm of ill-defined sites within the digestive system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C300",
	 description = " Malignant neoplasm of nasal cavity",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C301",
	 description = " Malignant neoplasm of middle ear",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C310",
	 description = " Malignant neoplasm of maxillary sinus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C311",
	 description = " Malignant neoplasm of ethmoidal sinus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C312",
	 description = " Malignant neoplasm of frontal sinus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C313",
	 description = " Malignant neoplasm of sphenoid sinus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C318",
	 description = " Malignant neoplasm of overlapping sites of accessory sinuses",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C319",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C320",
	 description = " Malignant neoplasm of glottis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C321",
	 description = " Malignant neoplasm of supraglottis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C322",
	 description = " Malignant neoplasm of subglottis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C323",
	 description = " Malignant neoplasm of laryngeal cartilage",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C328",
	 description = " Malignant neoplasm of overlapping sites of larynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C329",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C33",
	 description = " Malignant neoplasm of trachea",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C3400",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C3401",
	 description = " Malignant neoplasm of right main bronchus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C3402",
	 description = " Malignant neoplasm of left main bronchus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C3410   Malignant neoplasm of upper lobe",
	 description = "bronchus or lung",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C3411",
	 description = "Malignant",
	 additional = "right bronchus or lung"
},
new ICD10
{
	 code = "C3412",
	 description = "Malignant",
	 additional = "left bronchus or lung"
},
new ICD10
{
	 code = "C342",
	 description = "Malignant",
	 additional = "right bronchus or lung"
},
new ICD10
{
	 code = "C3430   Malignant neoplasm of lower lobe",
	 description = "bronchus or lung",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C3431",
	 description = "Malignant",
	 additional = "right bronchus or lung"
},
new ICD10
{
	 code = "C3432",
	 description = "Malignant",
	 additional = "left bronchus or lung"
},
new ICD10
{
	 code = "C3480",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C3481",
	 description = " Malignant neoplasm of overlapping sites of right bronchus and lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C3482",
	 description = " Malignant neoplasm of overlapping sites of left bronchus and lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C3490   Malignant neoplasm of bronchus or lung",
	 description = "unspecified",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C3491",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C3492",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C37",
	 description = " Malignant neoplasm of thymus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C380",
	 description = " Malignant neoplasm of heart",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C381",
	 description = " Malignant neoplasm of anterior mediastinum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C382",
	 description = " Malignant neoplasm of posterior mediastinum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C383",
	 description = "Malignant",
	 additional = "part unspecified"
},
new ICD10
{
	 code = "C384",
	 description = " Malignant neoplasm of pleura",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C388",
	 description = "Malignant",
	 additional = "mediastinum and pleura"
},
new ICD10
{
	 code = "C390",
	 description = "Malignant",
	 additional = "part unspecified"
},
new ICD10
{
	 code = "C399",
	 description = "Malignant",
	 additional = "part unspecified"
},
new ICD10
{
	 code = "C4000",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4001",
	 description = " Malignant neoplasm of scapula and long bones of right upper limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4002",
	 description = " Malignant neoplasm of scapula and long bones of left upper limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4010",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4011",
	 description = " Malignant neoplasm of short bones of right upper limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4012",
	 description = " Malignant neoplasm of short bones of left upper limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4020",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4021",
	 description = " Malignant neoplasm of long bones of right lower limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4022",
	 description = " Malignant neoplasm of long bones of left lower limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4030",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4031",
	 description = " Malignant neoplasm of short bones of right lower limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4032",
	 description = " Malignant neoplasm of short bones of left lower limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4080",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4081",
	 description = " Malignant neoplasm of overlapping sites of bone and articular cartilage of right limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4082",
	 description = " Malignant neoplasm of overlapping sites of bone and articular cartilage of left limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4090   Malignant neoplasm of bones and articular cartilage of limb",
	 description = "unspecified",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4091",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4092",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C410",
	 description = " Malignant neoplasm of bones of skull and face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C411",
	 description = " Malignant neoplasm of mandible",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C412",
	 description = " Malignant neoplasm of vertebral column",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C413",
	 description = "Malignant",
	 additional = "sternum and clavicle"
},
new ICD10
{
	 code = "C414",
	 description = "Malignant",
	 additional = "sacrum and coccyx"
},
new ICD10
{
	 code = "C419",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C430",
	 description = " Malignant melanoma of lip",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4310   Malignant melanoma of eyelid",
	 description = "including canthus",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4311",
	 description = "Malignant",
	 additional = "including canthus"
},
new ICD10
{
	 code = "C4312",
	 description = "Malignant",
	 additional = "including canthus"
},
new ICD10
{
	 code = "C4320",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4321",
	 description = " Malignant melanoma of right ear and external auricular canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4322",
	 description = " Malignant melanoma of left ear and external auricular canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4330",
	 description = " Malignant melanoma of unspecified part of face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4331",
	 description = " Malignant melanoma of nose",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4339",
	 description = " Malignant melanoma of other parts of face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C434",
	 description = " Malignant melanoma of scalp and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4351",
	 description = " Malignant melanoma of anal skin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4352",
	 description = " Malignant melanoma of skin of breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4359",
	 description = " Malignant melanoma of other part of trunk",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4360   Malignant melanoma of upper limb",
	 description = "including shoulder",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4361",
	 description = "Malignant",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "C4362",
	 description = "Malignant",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "C4370   Malignant melanoma of lower limb",
	 description = "including hip",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4371",
	 description = "Malignant",
	 additional = "including hip"
},
new ICD10
{
	 code = "C4372",
	 description = "Malignant",
	 additional = "including hip"
},
new ICD10
{
	 code = "C438",
	 description = " Overlapping malignant melanoma of skin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C439",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C440",
	 description = " Malignant neoplasm of skin of lip",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4410   Malignant neoplasm of skin of eyelid",
	 description = "including canthus",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4411",
	 description = "Malignant",
	 additional = "including canthus"
},
new ICD10
{
	 code = "C4412",
	 description = "Malignant",
	 additional = "including canthus"
},
new ICD10
{
	 code = "C4420",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4421",
	 description = " Malignant neoplasm of skin of right ear and external auricular canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4422",
	 description = " Malignant neoplasm of skin of left ear and external auricular canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4430",
	 description = " Malignant neoplasm of skin of unspecified part of face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4431",
	 description = " Malignant neoplasm of skin of nose",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4439",
	 description = " Malignant neoplasm of skin of other parts of face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C444",
	 description = " Malignant neoplasm of skin of scalp and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4451",
	 description = " Malignant neoplasm of anal skin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4452",
	 description = " Malignant neoplasm of skin of breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4459",
	 description = " Malignant neoplasm of other part of trunk",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4460   Malignant neoplasm of skin of upper limb",
	 description = "including shoulder",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4461",
	 description = "Malignant",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "C4462",
	 description = "Malignant",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "C4470   Malignant neoplasm of skin of lower limb",
	 description = "including hip",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4471",
	 description = "Malignant",
	 additional = "including hip"
},
new ICD10
{
	 code = "C4472",
	 description = "Malignant",
	 additional = "including hip"
},
new ICD10
{
	 code = "C448",
	 description = " Malignant neoplasm of overlapping sites of skin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C449",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C450",
	 description = " Mesothelioma of pleura",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C451",
	 description = " Mesothelioma of peritoneum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C452",
	 description = " Mesothelioma of pericardium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C457",
	 description = " Mesothelioma of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C459",
	 description = "Mesothelioma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C460",
	 description = " Kaposi's sarcoma of skin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C461",
	 description = " Kaposi's sarcoma of soft tissue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C462",
	 description = " Kaposi's sarcoma of palate",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C463",
	 description = " Kaposi's sarcoma of lymph nodes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C464",
	 description = " Kaposi's sarcoma of gastrointestinal sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4650",
	 description = "Kaposi's",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4651",
	 description = " Kaposi's sarcoma of right lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C4652",
	 description = " Kaposi's sarcoma of left lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C467",
	 description = " Kaposi's sarcoma of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C469",
	 description = "Kaposi's",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C470",
	 description = "Malignant",
	 additional = "face and neck"
},
new ICD10
{
	 code = "C4710   Malignant neoplasm of peripheral nerves of upper limb",
	 description = "including shoulder",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4711",
	 description = "Malignant",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "C4712",
	 description = "Malignant",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "C4720   Malignant neoplasm of peripheral nerves of lower limb",
	 description = "including hip",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4721",
	 description = "Malignant",
	 additional = "including hip"
},
new ICD10
{
	 code = "C4722",
	 description = "Malignant",
	 additional = "including hip"
},
new ICD10
{
	 code = "C473",
	 description = " Malignant neoplasm of peripheral nerves of thorax",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C474",
	 description = " Malignant neoplasm of peripheral nerves of abdomen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C475",
	 description = " Malignant neoplasm of peripheral nerves of pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C476",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C478",
	 description = " Malignant neoplasm of overlapping sites of peripheral nerves and autonomic nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C479",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C480",
	 description = " Malignant neoplasm of retroperitoneum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C481",
	 description = " Malignant neoplasm of specified parts of peritoneum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C482",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C488",
	 description = " Malignant neoplasm of overlapping sites of retroperitoneum and peritoneum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C490",
	 description = "Malignant",
	 additional = "face and neck"
},
new ICD10
{
	 code = "C4910   Malignant neoplasm of connective and soft tissue of upper limb",
	 description = "including shoulder",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4911",
	 description = "Malignant",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "C4912",
	 description = "Malignant",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "C4920   Malignant neoplasm of connective and soft tissue of lower limb",
	 description = "including hip",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C4921",
	 description = "Malignant",
	 additional = "including hip"
},
new ICD10
{
	 code = "C4922",
	 description = "Malignant",
	 additional = "including hip"
},
new ICD10
{
	 code = "C493",
	 description = " Malignant neoplasm of connective and soft tissue of thorax",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C494",
	 description = " Malignant neoplasm of connective and soft tissue of abdomen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C495",
	 description = " Malignant neoplasm of connective and soft tissue of pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C496",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C498",
	 description = " Malignant neoplasm of overlapping sites of connective and soft tissue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C499",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50011",
	 description = "Malignant",
	 additional = "right female breast"
},
new ICD10
{
	 code = "C50012",
	 description = "Malignant",
	 additional = "left female breast"
},
new ICD10
{
	 code = "C50019",
	 description = "Malignant",
	 additional = "unspecified female breast"
},
new ICD10
{
	 code = "C50021",
	 description = "Malignant",
	 additional = "right male breast"
},
new ICD10
{
	 code = "C50022",
	 description = "Malignant",
	 additional = "left male breast"
},
new ICD10
{
	 code = "C50029",
	 description = "Malignant",
	 additional = "unspecified male breast"
},
new ICD10
{
	 code = "C50111",
	 description = " Malignant neoplasm of central portion of right female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50112",
	 description = " Malignant neoplasm of central portion of left female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50119",
	 description = " Malignant neoplasm of central portion of unspecified female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50121",
	 description = " Malignant neoplasm of central portion of right male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50122",
	 description = " Malignant neoplasm of central portion of left male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50129",
	 description = " Malignant neoplasm of central portion of unspecified male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50211",
	 description = " Malignant neoplasm of upper-inner quadrant of right female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50212",
	 description = " Malignant neoplasm of upper-inner quadrant of left female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50219",
	 description = " Malignant neoplasm of upper-inner quadrant of unspecified female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50221",
	 description = " Malignant neoplasm of upper-inner quadrant of right male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50222",
	 description = " Malignant neoplasm of upper-inner quadrant of left male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50229",
	 description = " Malignant neoplasm of upper-inner quadrant of unspecified male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50311",
	 description = " Malignant neoplasm of lower-inner quadrant of right female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50312",
	 description = " Malignant neoplasm of lower-inner quadrant of left female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50319",
	 description = " Malignant neoplasm of lower-inner quadrant of unspecified female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50321",
	 description = " Malignant neoplasm of lower-inner quadrant of right male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50322",
	 description = " Malignant neoplasm of lower-inner quadrant of left male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50329",
	 description = " Malignant neoplasm of lower-inner quadrant of unspecified male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50411",
	 description = " Malignant neoplasm of upper-outer quadrant of right female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50412",
	 description = " Malignant neoplasm of upper-outer quadrant of left female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50419",
	 description = " Malignant neoplasm of upper-outer quadrant of unspecified female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50421",
	 description = " Malignant neoplasm of upper-outer quadrant of right male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50422",
	 description = " Malignant neoplasm of upper-outer quadrant of left male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50429",
	 description = " Malignant neoplasm of upper-outer quadrant of unspecified male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50511",
	 description = " Malignant neoplasm of lower-outer quadrant of right female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50512",
	 description = " Malignant neoplasm of lower-outer quadrant of left female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50519",
	 description = " Malignant neoplasm of lower-outer quadrant of unspecified female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50521",
	 description = " Malignant neoplasm of lower-outer quadrant of right male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50522",
	 description = " Malignant neoplasm of lower-outer quadrant of left male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50529",
	 description = " Malignant neoplasm of lower-outer quadrant of unspecified male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50611",
	 description = " Malignant neoplasm of axillary tail of right female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50612",
	 description = " Malignant neoplasm of axillary tail of left female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50619",
	 description = " Malignant neoplasm of axillary tail of unspecified female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50621",
	 description = " Malignant neoplasm of axillary tail of right male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50622",
	 description = " Malignant neoplasm of axillary tail of left male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50629",
	 description = " Malignant neoplasm of axillary tail of unspecified male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50811",
	 description = " Malignant neoplasm of overlapping sites of right female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50812",
	 description = " Malignant neoplasm of overlapping sites of left female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50819",
	 description = " Malignant neoplasm of overlapping sites of unspecified female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50821",
	 description = " Malignant neoplasm of overlapping sites of right male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50822",
	 description = " Malignant neoplasm of overlapping sites of left male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50829",
	 description = " Malignant neoplasm of overlapping sites of unspecified male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50911",
	 description = " Malignant neoplasm of unspecified site of right female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50912",
	 description = " Malignant neoplasm of unspecified site of left female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50919",
	 description = " Malignant neoplasm of unspecified site of unspecified female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50921",
	 description = " Malignant neoplasm of unspecified site of right male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50922",
	 description = " Malignant neoplasm of unspecified site of left male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C50929",
	 description = " Malignant neoplasm of unspecified site of unspecified male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C510",
	 description = " Malignant neoplasm of labium majus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C511",
	 description = " Malignant neoplasm of labium minus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C512",
	 description = " Malignant neoplasm of clitoris",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C518",
	 description = " Malignant neoplasm of overlapping sites of vulva",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C519",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C52",
	 description = " Malignant neoplasm of vagina",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C530",
	 description = " Malignant neoplasm of endocervix",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C531",
	 description = " Malignant neoplasm of exocervix",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C538",
	 description = " Malignant neoplasm of overlapping sites of cervix uteri",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C539",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C540",
	 description = " Malignant neoplasm of isthmus uteri",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C541",
	 description = " Malignant neoplasm of endometrium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C542",
	 description = " Malignant neoplasm of myometrium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C543",
	 description = " Malignant neoplasm of fundus uteri",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C548",
	 description = " Malignant neoplasm of overlapping sites of corpus uteri",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C549",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C55",
	 description = "Malignant",
	 additional = "part unspecified"
},
new ICD10
{
	 code = "C560",
	 description = " Malignant neoplasm of right ovary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C561",
	 description = " Malignant neoplasm of left ovary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C569",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C5700",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C5701",
	 description = " Malignant neoplasm of right fallopian tube",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C5702",
	 description = " Malignant neoplasm of left fallopian tube",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C5710",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C5711",
	 description = " Malignant neoplasm of right broad ligament",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C5712",
	 description = " Malignant neoplasm of left broad ligament",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C5720",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C5721",
	 description = " Malignant neoplasm of right round ligament",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C5722",
	 description = " Malignant neoplasm of left round ligament",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C573",
	 description = " Malignant neoplasm of parametrium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C574",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C577",
	 description = " Malignant neoplasm of other specified female genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C578",
	 description = " Malignant neoplasm of overlapping sites of female genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C579",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C58",
	 description = " Malignant neoplasm of placenta",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C600",
	 description = " Malignant neoplasm of prepuce",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C601",
	 description = " Malignant neoplasm of glans penis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C602",
	 description = " Malignant neoplasm of body of penis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C608",
	 description = " Malignant neoplasm of overlapping sites of penis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C609",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C61",
	 description = " Malignant neoplasm of prostate",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6200",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6201",
	 description = " Malignant neoplasm of undescended right testis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6202",
	 description = " Malignant neoplasm of undescended left testis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6210",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6211",
	 description = " Malignant neoplasm of descended right testis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6212",
	 description = " Malignant neoplasm of descended left testis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6290   Malignant neoplasm of testis",
	 description = "unspecified",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6291",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6292",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6300",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6301",
	 description = " Malignant neoplasm of right epididymis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6302",
	 description = " Malignant neoplasm of left epididymis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6310",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6311",
	 description = " Malignant neoplasm of right spermatic cord",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6312",
	 description = " Malignant neoplasm of left spermatic cord",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C632",
	 description = " Malignant neoplasm of scrotum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C637",
	 description = " Malignant neoplasm of other specified male genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C638",
	 description = " Malignant neoplasm of overlapping sites of male genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C639",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C640",
	 description = "Malignant",
	 additional = "except renal pelvis"
},
new ICD10
{
	 code = "C641",
	 description = "Malignant",
	 additional = "except renal pelvis"
},
new ICD10
{
	 code = "C649    Malignant neoplasm of kidney",
	 description = "except renal pelvis",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C650",
	 description = " Malignant neoplasm of right renal pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C651",
	 description = " Malignant neoplasm of left renal pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C659",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C660",
	 description = " Malignant neoplasm of right ureter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C661",
	 description = " Malignant neoplasm of left ureter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C669",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C670",
	 description = " Malignant neoplasm of trigone of bladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C671",
	 description = " Malignant neoplasm of dome of bladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C672",
	 description = " Malignant neoplasm of lateral wall of bladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C673",
	 description = " Malignant neoplasm of anterior wall of bladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C674",
	 description = " Malignant neoplasm of posterior wall of bladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C675",
	 description = " Malignant neoplasm of bladder neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C676",
	 description = " Malignant neoplasm of ureteric orifice",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C677",
	 description = " Malignant neoplasm of urachus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C678",
	 description = " Malignant neoplasm of overlapping sites of bladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C679",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C680",
	 description = " Malignant neoplasm of urethra",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C681",
	 description = " Malignant neoplasm of paraurethral glands",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C688",
	 description = " Malignant neoplasm of overlapping sites of urinary organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C689",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6900",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6901",
	 description = " Malignant neoplasm of right conjunctiva",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6902",
	 description = " Malignant neoplasm of left conjunctiva",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6910",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6911",
	 description = " Malignant neoplasm of right cornea",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6912",
	 description = " Malignant neoplasm of left cornea",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6920",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6921",
	 description = " Malignant neoplasm of right retina",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6922",
	 description = " Malignant neoplasm of left retina",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6930",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6931",
	 description = " Malignant neoplasm of right choroid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6932",
	 description = " Malignant neoplasm of left choroid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6940",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6941",
	 description = " Malignant neoplasm of right ciliary body",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6942",
	 description = " Malignant neoplasm of left ciliary body",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6950",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6951",
	 description = " Malignant neoplasm of right lacrimal gland and duct",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6952",
	 description = " Malignant neoplasm of left lacrimal gland and duct",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6960",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6961",
	 description = " Malignant neoplasm of right orbit",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6962",
	 description = " Malignant neoplasm of left orbit",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6980",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6981",
	 description = " Malignant neoplasm of overlapping sites of right eye and adnexa",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6982",
	 description = " Malignant neoplasm of overlapping sites of left eye and adnexa",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6990   Malignant neoplasm of eye",
	 description = "unspecified",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C6991",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C6992",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C700",
	 description = " Malignant neoplasm of cerebral meninges",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C701",
	 description = " Malignant neoplasm of spinal meninges",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C709",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C710",
	 description = "Malignant",
	 additional = "except lobes and ventricles"
},
new ICD10
{
	 code = "C711",
	 description = " Malignant neoplasm of frontal lobe",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C712",
	 description = " Malignant neoplasm of temporal lobe",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C713",
	 description = " Malignant neoplasm of parietal lobe",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C714",
	 description = " Malignant neoplasm of occipital lobe",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C715",
	 description = " Malignant neoplasm of cerebral ventricle",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C716",
	 description = " Malignant neoplasm of cerebellum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C717",
	 description = " Malignant neoplasm of brain stem",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C718",
	 description = " Malignant neoplasm of overlapping sites of brain",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C719",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C720",
	 description = " Malignant neoplasm of spinal cord",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C721",
	 description = " Malignant neoplasm of cauda equina",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7220",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C7221",
	 description = " Malignant neoplasm of right olfactory nerve",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7222",
	 description = " Malignant neoplasm of left olfactory nerve",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7230",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C7231",
	 description = " Malignant neoplasm of right optic nerve",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7232",
	 description = " Malignant neoplasm of left optic nerve",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7240",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C7241",
	 description = " Malignant neoplasm of right acoustic nerve",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7242",
	 description = " Malignant neoplasm of left acoustic nerve",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7250",
	 description = " Malignant neoplasm of unspecified cranial nerve",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7259",
	 description = " Malignant neoplasm of other cranial nerves",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C729",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C73",
	 description = " Malignant neoplasm of thyroid gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7400",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C7401",
	 description = " Malignant neoplasm of cortex of right adrenal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7402",
	 description = " Malignant neoplasm of cortex of left adrenal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7410",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C7411",
	 description = " Malignant neoplasm of medulla of right adrenal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7412",
	 description = " Malignant neoplasm of medulla of left adrenal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7490   Malignant neoplasm of adrenal gland",
	 description = "unspecified",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C7491",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7492",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C750",
	 description = " Malignant neoplasm of parathyroid gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C751",
	 description = " Malignant neoplasm of pituitary gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C752",
	 description = " Malignant neoplasm of craniopharyngeal duct",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C753",
	 description = " Malignant neoplasm of pineal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C754",
	 description = " Malignant neoplasm of carotid body",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C755",
	 description = " Malignant neoplasm of aortic body and other paraganglia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C758",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C759",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C760",
	 description = "Malignant",
	 additional = "face and neck"
},
new ICD10
{
	 code = "C761",
	 description = " Malignant neoplasm of thorax",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C762",
	 description = " Malignant neoplasm of abdomen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C763",
	 description = " Malignant neoplasm of pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7640",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C7641",
	 description = " Malignant neoplasm of right upper limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7642",
	 description = " Malignant neoplasm of left upper limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7650",
	 description = "Malignant",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C7651",
	 description = " Malignant neoplasm of right lower limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7652",
	 description = " Malignant neoplasm of left lower limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C767",
	 description = " Malignant neoplasm of other ill-defined sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C768",
	 description = " Malignant neoplasm of overlapping sites of other and ill-defined sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C770",
	 description = "Secondary",
	 additional = "face and neck"
},
new ICD10
{
	 code = "C771",
	 description = " Secondary and unspecified malignant neoplasm of intrathoracic lymph nodes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C772",
	 description = " Secondary and unspecified malignant neoplasm of intra-abdominal lymph nodes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C773",
	 description = " Secondary and unspecified malignant neoplasm of axilla and upper limb lymph nodes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C774",
	 description = " Secondary and unspecified malignant neoplasm of inguinal and lower limb lymph nodes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C775",
	 description = " Secondary and unspecified malignant neoplasm of intrapelvic lymph nodes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C778",
	 description = " Secondary and unspecified malignant neoplasm of lymph nodes of multiple regions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C779",
	 description = "Secondary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7800",
	 description = "Secondary",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C7801",
	 description = " Secondary malignant neoplasm of right lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7802",
	 description = " Secondary malignant neoplasm of left lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C781",
	 description = " Secondary malignant neoplasm of mediastinum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C782",
	 description = " Secondary malignant neoplasm of pleura",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7830",
	 description = " Secondary malignant neoplasm of unspecified respiratory organ",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7839",
	 description = " Secondary malignant neoplasm of other respiratory organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C784",
	 description = " Secondary malignant neoplasm of small intestine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C785",
	 description = " Secondary malignant neoplasm of large intestine and rectum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C786",
	 description = " Secondary malignant neoplasm of retroperitoneum and peritoneum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C787",
	 description = " Secondary malignant neoplasm of liver",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7880",
	 description = " Secondary malignant neoplasm of unspecified digestive organ",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7889",
	 description = " Secondary malignant neoplasm of other digestive organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7900",
	 description = "Secondary",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C7901",
	 description = " Secondary malignant neoplasm of right kidney and renal pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7902",
	 description = " Secondary malignant neoplasm of left kidney and renal pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7910",
	 description = " Secondary malignant neoplasm of unspecified urinary organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7911",
	 description = " Secondary malignant neoplasm of bladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7919",
	 description = " Secondary malignant neoplasm of other urinary organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C792",
	 description = " Secondary malignant neoplasm of skin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7931",
	 description = " Secondary malignant neoplasm of brain",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7932",
	 description = " Secondary malignant neoplasm of cerebral meninges",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7940",
	 description = " Secondary malignant neoplasm of unspecified part of nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7949",
	 description = " Secondary malignant neoplasm of other parts of nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7951",
	 description = " Secondary malignant neoplasm of bone",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7952",
	 description = " Secondary malignant neoplasm of bone marrow",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7960",
	 description = "Secondary",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C7961",
	 description = " Secondary malignant neoplasm of right ovary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7962",
	 description = " Secondary malignant neoplasm of left ovary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7970",
	 description = "Secondary",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "C7971",
	 description = " Secondary malignant neoplasm of right adrenal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7972",
	 description = " Secondary malignant neoplasm of left adrenal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7981",
	 description = " Secondary malignant neoplasm of breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7982",
	 description = " Secondary malignant neoplasm of genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C7989",
	 description = " Secondary malignant neoplasm of other specified sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C800",
	 description = "Disseminated",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C801",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8100",
	 description = "Lymphocytic",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8101",
	 description = " Lymphocytic predominance Hodgkin's disease, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8102",
	 description = "Lymphocytic",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8103",
	 description = "Lymphocytic",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8104",
	 description = "Lymphocytic",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8105",
	 description = "Lymphocytic",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8106",
	 description = "Lymphocytic",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8107",
	 description = "Lymphocytic",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8108",
	 description = "Lymphocytic",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8109",
	 description = "Lymphocytic",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8110",
	 description = "Nodular",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8111",
	 description = " Nodular sclerosis Hodgkin's disease, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8112",
	 description = "Nodular",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8113",
	 description = "Nodular",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8114",
	 description = "Nodular",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8115",
	 description = "Nodular",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8116",
	 description = "Nodular",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8117",
	 description = "Nodular",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8118",
	 description = "Nodular",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8119",
	 description = "Nodular",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8120",
	 description = "Mixed",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8121",
	 description = " Mixed cellularity Hodgkin's disease, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8122",
	 description = "Mixed",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8123",
	 description = "Mixed",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8124",
	 description = "Mixed",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8125",
	 description = "Mixed",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8126",
	 description = "Mixed",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8127",
	 description = "Mixed",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8128",
	 description = "Mixed",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8129",
	 description = "Mixed",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8130",
	 description = "Lymphocytic",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8131",
	 description = " Lymphocytic depletion Hodgkin's disease, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8132",
	 description = "Lymphocytic",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8133",
	 description = "Lymphocytic",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8134",
	 description = "Lymphocytic",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8135",
	 description = "Lymphocytic",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8136",
	 description = "Lymphocytic",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8137",
	 description = "Lymphocytic",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8138",
	 description = "Lymphocytic",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8139",
	 description = "Lymphocytic",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8170",
	 description = "Other",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8171",
	 description = " Other Hodgkin's disease, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8172",
	 description = "Other",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8173",
	 description = "Other",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8174",
	 description = "Other",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8175",
	 description = "Other",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8176",
	 description = "Other",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8177",
	 description = "Other",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8178",
	 description = "Other",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8179",
	 description = "Other",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8190",
	 description = "Unspecified",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8191",
	 description = " Unspecified Hodgkin's disease, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8192",
	 description = "Unspecified",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8193",
	 description = "Unspecified",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8194",
	 description = "Unspecified",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8195",
	 description = "Unspecified",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8196",
	 description = "Unspecified",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8197",
	 description = "Unspecified",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8198",
	 description = "Unspecified",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8199",
	 description = "Unspecified",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8200   Small cleaved cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8201",
	 description = " Small cleaved cell, follicular non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8202   Small cleaved cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8203   Small cleaved cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8204   Small cleaved cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8205   Small cleaved cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8206   Small cleaved cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8207   Small cleaved cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8208   Small cleaved cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8209   Small cleaved cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8210   Mixed small cleaved and large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8211",
	 description = " Mixed small cleaved and large cell, follicular non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8212   Mixed small cleaved and large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8213   Mixed small cleaved and large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8214   Mixed small cleaved and large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8215   Mixed small cleaved and large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8216   Mixed small cleaved and large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8217   Mixed small cleaved and large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8218   Mixed small cleaved and large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8219   Mixed small cleaved and large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8220   Large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8221",
	 description = " Large cell, follicular non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8222   Large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8223   Large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8224   Large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8225   Large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8226   Large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8227   Large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8228   Large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8229   Large cell",
	 description = "follicular non-Hodgkin's lymphoma",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8270",
	 description = "Other",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8271",
	 description = " Other types of follicular non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8272",
	 description = "Other",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8273",
	 description = "Other",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8274",
	 description = "Other",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8275",
	 description = "Other",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8276",
	 description = "Other",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8277",
	 description = "Other",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8278",
	 description = "Other",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8279",
	 description = "Other",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8290",
	 description = "Unspecified",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8291",
	 description = " Unspecified follicular non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8292",
	 description = "Unspecified",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8293   Unspecified follicular non-Hodgkin's lymphoma",
	 description = "unspecified",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8294",
	 description = "Unspecified",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8295",
	 description = "Unspecified",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8296",
	 description = "Unspecified",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8297",
	 description = "Unspecified",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8298",
	 description = "Unspecified",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8299",
	 description = "Unspecified",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8300",
	 description = "Small",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8301",
	 description = " Small cell (diffuse) non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8302",
	 description = "Small",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8303",
	 description = "Small",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8304",
	 description = "Small",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8305",
	 description = "Small",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8306",
	 description = "Small",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8307",
	 description = "Small",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8308",
	 description = "Small",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8309",
	 description = "Small",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8310",
	 description = "Small",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8311",
	 description = " Small cleaved cell (diffuse) non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8312",
	 description = "Small",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8313",
	 description = "Small",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8314",
	 description = "Small",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8315",
	 description = "Small",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8316",
	 description = "Small",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8317",
	 description = "Small",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8318",
	 description = "Small",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8319",
	 description = "Small",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8320",
	 description = "Mixed",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8321",
	 description = " Mixed small and large cell (diffuse) non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8322",
	 description = "Mixed",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8323",
	 description = "Mixed",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8324",
	 description = "Mixed",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8325",
	 description = "Mixed",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8326",
	 description = "Mixed",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8327",
	 description = "Mixed",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8328",
	 description = "Mixed",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8329",
	 description = "Mixed",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8330",
	 description = "Large",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8331",
	 description = " Large cell (diffuse) non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8332",
	 description = "Large",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8333",
	 description = "Large",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8334",
	 description = "Large",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8335",
	 description = "Large",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8336",
	 description = "Large",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8337",
	 description = "Large",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8338",
	 description = "Large",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8339",
	 description = "Large",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8340",
	 description = "Immunoblastic",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8341",
	 description = " Immunoblastic (diffuse) non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8342",
	 description = "Immunoblastic",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8343",
	 description = "Immunoblastic",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8344",
	 description = "Immunoblastic",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8345",
	 description = "Immunoblastic",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8346",
	 description = "Immunoblastic",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8347",
	 description = "Immunoblastic",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8348",
	 description = "Immunoblastic",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8349",
	 description = "Immunoblastic",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8350",
	 description = "Lymphoblastic",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8351",
	 description = " Lymphoblastic (diffuse) non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8352",
	 description = "Lymphoblastic",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8353",
	 description = "Lymphoblastic",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8354",
	 description = "Lymphoblastic",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8355",
	 description = "Lymphoblastic",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8356",
	 description = "Lymphoblastic",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8357",
	 description = "Lymphoblastic",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8358",
	 description = "Lymphoblastic",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8359",
	 description = "Lymphoblastic",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8360",
	 description = "Undifferentiated",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8361",
	 description = " Undifferentiated (diffuse) non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8362",
	 description = "Undifferentiated",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8363",
	 description = "Undifferentiated",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8364",
	 description = "Undifferentiated",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8365",
	 description = "Undifferentiated",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8366",
	 description = "Undifferentiated",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8367",
	 description = "Undifferentiated",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8368",
	 description = "Undifferentiated",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8369",
	 description = "Undifferentiated",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8370",
	 description = "Burkitt's",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8371",
	 description = " Burkitt's tumor, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8372",
	 description = "Burkitt's",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8373",
	 description = "Burkitt's",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8374",
	 description = "Burkitt's",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8375",
	 description = "Burkitt's",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8376",
	 description = "Burkitt's",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8377",
	 description = "Burkitt's",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8378",
	 description = "Burkitt's",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8379",
	 description = "Burkitt's",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8380",
	 description = "Other",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8381",
	 description = " Other types of diffuse non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8382",
	 description = "Other",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8383",
	 description = "Other",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8384",
	 description = "Other",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8385",
	 description = "Other",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8386",
	 description = "Other",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8387",
	 description = " Other types of diffuse non-Hodgkin's lymphoma of spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8388",
	 description = "Other",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8389",
	 description = "Other",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8390",
	 description = "Unspecified",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8391",
	 description = " Unspecified diffuse non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8392",
	 description = "Unspecified",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8393",
	 description = "Unspecified",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8394",
	 description = "Unspecified",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8395",
	 description = "Unspecified",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8396",
	 description = "Unspecified",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8397",
	 description = "Unspecified",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8398",
	 description = "Unspecified",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8399",
	 description = "Unspecified",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8400",
	 description = "Mycosis",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8401",
	 description = " Mycosis fungoides, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8402",
	 description = "Mycosis",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8403",
	 description = "Mycosis",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8404",
	 description = "Mycosis",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8405",
	 description = "Mycosis",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8406",
	 description = "Mycosis",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8407",
	 description = "Mycosis",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8408",
	 description = "Mycosis",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8409",
	 description = "Mycosis",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8410",
	 description = "Sezary's",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8411",
	 description = " Sezary's disease, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8412",
	 description = "Sezary's",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8413",
	 description = "Sezary's",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8414",
	 description = "Sezary's",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8415",
	 description = "Sezary's",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8416",
	 description = "Sezary's",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8417",
	 description = "Sezary's",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8418",
	 description = "Sezary's",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8419",
	 description = "Sezary's",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8420",
	 description = "T-zone",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8421",
	 description = " T-zone lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8422",
	 description = "T-zone",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8423",
	 description = "T-zone",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8424",
	 description = "T-zone",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8425",
	 description = "T-zone",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8426",
	 description = "T-zone",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8427",
	 description = "T-zone",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8428",
	 description = "T-zone",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8429",
	 description = "T-zone",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8430",
	 description = "Lymphoepithelioid",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8431",
	 description = " Lymphoepithelioid lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8432",
	 description = "Lymphoepithelioid",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8433",
	 description = "Lymphoepithelioid",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8434",
	 description = "Lymphoepithelioid",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8435",
	 description = "Lymphoepithelioid",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8436",
	 description = "Lymphoepithelioid",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8437",
	 description = "Lymphoepithelioid",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8438",
	 description = "Lymphoepithelioid",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8439",
	 description = "Lymphoepithelioid",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8440",
	 description = "Peripheral",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8441",
	 description = " Peripheral T-cell lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8442",
	 description = "Peripheral",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8443",
	 description = "Peripheral",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8444",
	 description = "Peripheral",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8445",
	 description = "Peripheral",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8446",
	 description = "Peripheral",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8447",
	 description = "Peripheral",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8448",
	 description = "Peripheral",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8449",
	 description = "Peripheral",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8450",
	 description = " Other and unspecified T-cell lymphomas unspecified site",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8451",
	 description = " Other and unspecified T-cell lymphomas, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8452",
	 description = "Other",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8453",
	 description = "Other",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8454",
	 description = "Other",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8455",
	 description = "Other",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8456",
	 description = "Other",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8457",
	 description = "Other",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8458",
	 description = "Other",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8459",
	 description = "Other",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8500",
	 description = "Lymphosarcoma",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8501",
	 description = " Lymphosarcoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8502",
	 description = "Lymphosarcoma",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8503",
	 description = "Lymphosarcoma",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8504",
	 description = "Lymphosarcoma",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8505",
	 description = "Lymphosarcoma",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8506",
	 description = "Lymphosarcoma",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8507",
	 description = "Lymphosarcoma",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8508",
	 description = "Lymphosarcoma",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8509",
	 description = "Lymphosarcoma",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8510",
	 description = "Unspecified",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8511",
	 description = " Unspecified B-cell lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8512",
	 description = "Unspecified",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8513",
	 description = "Unspecified",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8514",
	 description = "Unspecified",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8515",
	 description = "Unspecified",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8516",
	 description = "Unspecified",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8517",
	 description = "Unspecified",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8518",
	 description = "Unspecified",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8519",
	 description = "Unspecified",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8570",
	 description = "Other",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8571",
	 description = " Other specified types of non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8572",
	 description = "Other",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8573",
	 description = "Other",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8574",
	 description = "Other",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8575",
	 description = "Other",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8576",
	 description = "Other",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8577",
	 description = "Other",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8578",
	 description = "Other",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8579",
	 description = "Other",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C8590",
	 description = "Unspecified",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "C8591",
	 description = " Unspecified type non-Hodgkin's lymphoma, lymph nodes of head, face, and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C8592",
	 description = "Unspecified",
	 additional = "intrathoracic lymph nodes"
},
new ICD10
{
	 code = "C8593",
	 description = "Unspecified",
	 additional = "intra-abdominal lymph nodes"
},
new ICD10
{
	 code = "C8594",
	 description = "Unspecified",
	 additional = "lymph nodes of axilla and upper limb"
},
new ICD10
{
	 code = "C8595",
	 description = "Unspecified",
	 additional = "lymph nodes of inguinal region and lower limb"
},
new ICD10
{
	 code = "C8596",
	 description = "Unspecified",
	 additional = "intrapelvic lymph nodes"
},
new ICD10
{
	 code = "C8597",
	 description = "Unspecified",
	 additional = "spleen"
},
new ICD10
{
	 code = "C8598",
	 description = "Unspecified",
	 additional = "lymph nodes of multiple sites"
},
new ICD10
{
	 code = "C8599",
	 description = "Unspecified",
	 additional = "extranodal and solid organ sites"
},
new ICD10
{
	 code = "C880",
	 description = " Waldenstrom's macroglobulinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C881",
	 description = " Alpha heavy chain disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C882",
	 description = " Gamma heavy chain disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C883",
	 description = " Immunoproliferative small intestinal disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C887",
	 description = " Other malignant immunoproliferative diseases",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C889",
	 description = "Malignant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C9000",
	 description = " Multiple myeloma not in remission",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C9001",
	 description = " Multiple myeloma in remission",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C9010",
	 description = " Plasma cell leukemia not in remission",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C9011",
	 description = " Plasma cell leukemia in remission",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C9020",
	 description = "Plasmacytoma",
	 additional = "extramedullary not in remission"
},
new ICD10
{
	 code = "C9021",
	 description = "Plasmacytoma",
	 additional = "extramedullary in remission"
},
new ICD10
{
	 code = "C9100",
	 description = "Acute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9101",
	 description = "Acute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9110",
	 description = "Chronic",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9111",
	 description = "Chronic",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9120",
	 description = "Subacute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9121",
	 description = "Subacute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9130",
	 description = "Prolymphocytic",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9131",
	 description = "Prolymphocytic",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9140",
	 description = "Hairy-cell",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9141",
	 description = "Hairy-cell",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9150",
	 description = "Adult",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9151",
	 description = "Adult",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9170",
	 description = "Other",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9171",
	 description = "Other",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9190   Lymphoid leukemia",
	 description = "unspecified",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9191   Lymphoid leukemia",
	 description = "unspecified",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9200",
	 description = "Acute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9201",
	 description = "Acute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9210",
	 description = "Chronic",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9211",
	 description = "Chronic",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9220",
	 description = "Subacute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9221",
	 description = "Subacute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9230",
	 description = "Myeloid",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9231",
	 description = "Myeloid",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9240",
	 description = "Acute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9241",
	 description = "Acute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9250",
	 description = "Acute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9251",
	 description = "Acute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9270",
	 description = "Other",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9271",
	 description = "Other",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9290   Myeloid leukemia",
	 description = "unspecified",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9291",
	 description = "Myeloid",
	 additional = "unspecified in remission"
},
new ICD10
{
	 code = "C9300",
	 description = "Acute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9301",
	 description = "Acute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9310",
	 description = "Chronic",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9311",
	 description = "Chronic",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9320",
	 description = "Subacute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9321",
	 description = "Subacute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9370",
	 description = "Other",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9371",
	 description = "Other",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9390   Monocytic leukemia",
	 description = "unspecified",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9391",
	 description = "Monocytic",
	 additional = "unspecified in remission"
},
new ICD10
{
	 code = "C9400",
	 description = "Acute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9401",
	 description = "Acute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9410",
	 description = "Chronic",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9411",
	 description = "Chronic",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9420",
	 description = "Acute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9421",
	 description = "Acute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9430",
	 description = "Mast",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9431",
	 description = "Mast",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9440",
	 description = "Acute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9441",
	 description = "Acute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9450",
	 description = "Acute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9451",
	 description = "Acute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9470",
	 description = "Other",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9471",
	 description = "Other",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9500",
	 description = "Acute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9501",
	 description = "Acute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9510",
	 description = "Chronic",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9511",
	 description = "Chronic",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9520",
	 description = "Subacute",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9521",
	 description = "Subacute",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9570",
	 description = "Other",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9571",
	 description = "Other",
	 additional = "in remission"
},
new ICD10
{
	 code = "C9590   Leukemia",
	 description = "unspecified",
	 additional = "not in remission"
},
new ICD10
{
	 code = "C9591   Leukemia",
	 description = "unspecified",
	 additional = "in remission"
},
new ICD10
{
	 code = "C960",
	 description = " Letterer-Siwe disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C961",
	 description = " Malignant histiocytosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C962",
	 description = " Malignant mast cell tumor",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C963",
	 description = " True histiocytic lymphoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "C967",
	 description = "Other",
	 additional = "hematopoietic and related tissue"
},
new ICD10
{
	 code = "C969    Malignant neoplasm of lymphoid",
	 description = "hematopoietic and related tissue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0000",
	 description = "Carcinoma",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "D0001",
	 description = " Carcinoma in situ of labial mucosa and vermilion border",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0002",
	 description = " Carcinoma in situ of buccal mucosa",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0003",
	 description = " Carcinoma in situ of gingiva and edentulous alveolar ridge",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0004",
	 description = " Carcinoma in situ of soft palate",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0005",
	 description = " Carcinoma in situ of hard palate",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0006",
	 description = " Carcinoma in situ of floor of mouth",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0007",
	 description = " Carcinoma in situ of tongue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0008",
	 description = " Carcinoma in situ of pharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D001",
	 description = " Carcinoma in situ of esophagus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D002",
	 description = " Carcinoma in situ of stomach",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D010",
	 description = " Carcinoma in situ of colon",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D011",
	 description = " Carcinoma in situ of rectosigmoid junction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D012",
	 description = " Carcinoma in situ of rectum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D013",
	 description = " Carcinoma in situ of anus and anal canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0140",
	 description = " Carcinoma in situ of unspecified part of intestine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0149",
	 description = " Carcinoma in situ of other parts of intestine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D015",
	 description = "Carcinoma",
	 additional = "gallbladder and bile ducts"
},
new ICD10
{
	 code = "D017",
	 description = " Carcinoma in situ of other specified digestive organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D019",
	 description = "Carcinoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D020",
	 description = " Carcinoma in situ of larynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D021",
	 description = " Carcinoma in situ of trachea",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0220",
	 description = "Carcinoma",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D0221",
	 description = " Carcinoma in situ of right bronchus and lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0222",
	 description = " Carcinoma in situ of left bronchus and lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D023",
	 description = " Carcinoma in situ of other parts of respiratory system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D024",
	 description = "Carcinoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D030",
	 description = " Melanoma in situ of lip",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0310   Melanoma in situ of eyelid",
	 description = "including canthus",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D0311",
	 description = "Melanoma",
	 additional = "including canthus"
},
new ICD10
{
	 code = "D0312",
	 description = "Melanoma",
	 additional = "including canthus"
},
new ICD10
{
	 code = "D0320",
	 description = "Melanoma",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D0321",
	 description = " Melanoma in situ of right ear and external auricular canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0322",
	 description = " Melanoma in situ of left ear and external auricular canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0330",
	 description = " Melanoma in situ of unspecified part of face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0339",
	 description = " Melanoma in situ of other parts of face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D034",
	 description = " Melanoma in situ of scalp and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0351",
	 description = " Melanoma in situ of anal skin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0352",
	 description = " Melanoma in situ of breast (skin) (soft tissue)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0359",
	 description = " Melanoma in situ of other part of trunk",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0360   Melanoma in situ of upper limb",
	 description = "including shoulder",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D0361",
	 description = "Melanoma",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "D0362",
	 description = "Melanoma",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "D0370   Melanoma in situ of lower limb",
	 description = "including hip",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D0371",
	 description = "Melanoma",
	 additional = "including hip"
},
new ICD10
{
	 code = "D0372",
	 description = "Melanoma",
	 additional = "including hip"
},
new ICD10
{
	 code = "D038",
	 description = " Melanoma in situ of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D039",
	 description = "Melanoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D040",
	 description = " Carcinoma in situ of skin of lip",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0410   Carcinoma in situ of skin of eyelid",
	 description = "including canthus",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D0411",
	 description = "Carcinoma",
	 additional = "including canthus"
},
new ICD10
{
	 code = "D0412",
	 description = "Carcinoma",
	 additional = "including canthus"
},
new ICD10
{
	 code = "D0420",
	 description = "Carcinoma",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D0421",
	 description = " Carcinoma in situ of skin of right ear and external auricular canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0422",
	 description = " Carcinoma in situ of skin of left ear and external auricular canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0430",
	 description = " Carcinoma in situ of skin of unspecified part of face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0439",
	 description = " Carcinoma in situ of skin of other parts of face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D044",
	 description = " Carcinoma in situ of skin of scalp and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D045",
	 description = " Carcinoma in situ of skin of trunk",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0460   Carcinoma in situ of skin of upper limb",
	 description = "including shoulder",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D0461",
	 description = "Carcinoma",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "D0462",
	 description = "Carcinoma",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "D0470   Carcinoma in situ of skin of lower limb",
	 description = "including hip",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D0471",
	 description = "Carcinoma",
	 additional = "including hip"
},
new ICD10
{
	 code = "D0472",
	 description = "Carcinoma",
	 additional = "including hip"
},
new ICD10
{
	 code = "D048",
	 description = " Carcinoma in situ of skin of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D049",
	 description = "Carcinoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0501",
	 description = " Lobular carcinoma in situ of right breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0502",
	 description = " Lobular carcinoma in situ of left breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0509",
	 description = " Lobular carcinoma in situ of unspecified breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0511",
	 description = " Intraductal carcinoma in situ of right breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0512",
	 description = " Intraductal carcinoma in situ of left breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0519",
	 description = " Intraductal carcinoma in situ of unspecified breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0571",
	 description = " Other carcinoma in situ of right breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0572",
	 description = " Other carcinoma in situ of left breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0579",
	 description = " Other carcinoma in situ of unspecified breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0591",
	 description = " Unspecified carcinoma in situ of right breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0592",
	 description = " Unspecified carcinoma in situ of left breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0599",
	 description = " Unspecified carcinoma in situ of unspecified breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D060",
	 description = " Carcinoma in situ of endocervix",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D061",
	 description = " Carcinoma in situ of exocervix",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D067",
	 description = " Carcinoma in situ of other parts of cervix",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D069",
	 description = "Carcinoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D070",
	 description = " Carcinoma in situ of endometrium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D071",
	 description = " Carcinoma in situ of vulva",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D072",
	 description = " Carcinoma in situ of vagina",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0730",
	 description = " Carcinoma in situ of unspecified female genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0739",
	 description = " Carcinoma in situ of other female genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D074",
	 description = " Carcinoma in situ of penis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D075",
	 description = " Carcinoma in situ of prostate",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0760",
	 description = " Carcinoma in situ of unspecified male genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0761",
	 description = " Carcinoma in situ of scrotum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0769",
	 description = " Carcinoma in situ of other male genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D090",
	 description = " Carcinoma in situ of bladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0910",
	 description = " Carcinoma in situ of unspecified urinary organ",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0919",
	 description = " Carcinoma in situ of other urinary organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0920",
	 description = "Carcinoma",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D0921",
	 description = " Carcinoma in situ of right eye",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D0922",
	 description = " Carcinoma in situ of left eye",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D093",
	 description = " Carcinoma in situ of thyroid and other endocrine glands",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D097",
	 description = " Carcinoma in situ of other specified sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D099",
	 description = "Carcinoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D100",
	 description = " Benign neoplasm of lip",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D101",
	 description = " Benign neoplasm of tongue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D102",
	 description = " Benign neoplasm of floor of mouth",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1030",
	 description = " Benign neoplasm of unspecified part of mouth",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1039",
	 description = " Benign neoplasm of other parts of mouth",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D104",
	 description = " Benign neoplasm of tonsil",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D105",
	 description = " Benign neoplasm of other parts of oropharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D106",
	 description = " Benign neoplasm of nasopharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D107",
	 description = " Benign neoplasm of hypopharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D109",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D110",
	 description = " Benign neoplasm of parotid gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D117",
	 description = " Benign neoplasm of other major salivary glands",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D119",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D120",
	 description = " Benign neoplasm of cecum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D121",
	 description = " Benign neoplasm of appendix",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D122",
	 description = " Benign neoplasm of ascending colon",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D123",
	 description = " Benign neoplasm of transverse colon",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D124",
	 description = " Benign neoplasm of descending colon",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D125",
	 description = " Benign neoplasm of sigmoid colon",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D126",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D127",
	 description = " Benign neoplasm of rectosigmoid junction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D128",
	 description = " Benign neoplasm of rectum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D129",
	 description = " Benign neoplasm of anus and anal canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D130",
	 description = " Benign neoplasm of esophagus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D131",
	 description = " Benign neoplasm of stomach",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D132",
	 description = " Benign neoplasm of duodenum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1330",
	 description = " Benign neoplasm of unspecified part of small intestine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1339",
	 description = " Benign neoplasm of other parts of small intestine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D134",
	 description = " Benign neoplasm of liver",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D135",
	 description = " Benign neoplasm of extrahepatic bile ducts",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D136",
	 description = " Benign neoplasm of pancreas",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D137",
	 description = " Benign neoplasm of endocrine pancreas",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D139",
	 description = " Benign neoplasm of ill-defined sites within the digestive system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D140",
	 description = "Benign",
	 additional = "nasal cavity and accessory sinuses"
},
new ICD10
{
	 code = "D141",
	 description = " Benign neoplasm of larynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D142",
	 description = " Benign neoplasm of trachea",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1430",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D1431",
	 description = " Benign neoplasm of right bronchus and lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1432",
	 description = " Benign neoplasm of left bronchus and lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D144",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D150",
	 description = " Benign neoplasm of thymus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D151",
	 description = " Benign neoplasm of heart",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D152",
	 description = " Benign neoplasm of mediastinum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D157",
	 description = " Benign neoplasm of other specified intrathoracic organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D159",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1600",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D1601",
	 description = " Benign neoplasm of scapula and long bones of right upper limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1602",
	 description = " Benign neoplasm of scapula and long bones of left upper limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1610",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D1611",
	 description = " Benign neoplasm of short bones of right upper limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1612",
	 description = " Benign neoplasm of short bones of left upper limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1620",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D1621",
	 description = " Benign neoplasm of long bones of right lower limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1622",
	 description = " Benign neoplasm of long bones of left lower limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1630",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D1631",
	 description = " Benign neoplasm of short bones of right lower limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1632",
	 description = " Benign neoplasm of short bones of left lower limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D164",
	 description = " Benign neoplasm of bones of skull and face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D165",
	 description = " Benign neoplasm of lower jaw bone",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D166",
	 description = " Benign neoplasm of vertebral column",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D167",
	 description = "Benign",
	 additional = "sternum and clavicle"
},
new ICD10
{
	 code = "D168",
	 description = "Benign",
	 additional = "sacrum and coccyx"
},
new ICD10
{
	 code = "D169",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D170",
	 description = "Benign",
	 additional = "face and neck"
},
new ICD10
{
	 code = "D171",
	 description = " Benign lipomatous neoplasm of skin and subcutaneous tissue of trunk",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1720",
	 description = " Benign lipomatous neoplasm of skin and subcutaneous tissue of unspecified limb",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1721",
	 description = " Benign lipomatous neoplasm of skin and subcutaneous tissue of right arm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1722",
	 description = " Benign lipomatous neoplasm of skin and subcutaneous tissue of left arm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1723",
	 description = " Benign lipomatous neoplasm of skin and subcutaneous tissue of right leg",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1724",
	 description = " Benign lipomatous neoplasm of skin and subcutaneous tissue of left leg",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1730",
	 description = " Benign lipomatous neoplasm of skin and subcutaneous tissue of unspecified sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1739",
	 description = " Benign lipomatous neoplasm of skin and subcutaneous tissue of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D174",
	 description = " Benign lipomatous neoplasm of intrathoracic organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D175",
	 description = " Benign lipomatous neoplasm of intra-abdominal organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D176",
	 description = " Benign lipomatous neoplasm of spermatic cord",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D177",
	 description = " Benign lipomatous neoplasm of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D179",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1800",
	 description = " Hemangioma unspecified site",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1801",
	 description = " Hemangioma of skin and subcutaneous tissue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1802",
	 description = " Hemangioma of intracranial structures",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1803",
	 description = " Hemangioma of intra-abdominal structures",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D1809",
	 description = " Hemangioma of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D181",
	 description = "Lymphangioma",
	 additional = "any site"
},
new ICD10
{
	 code = "D190",
	 description = " Benign neoplasm of mesothelial tissue of pleura",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D191",
	 description = " Benign neoplasm of mesothelial tissue of peritoneum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D197",
	 description = " Benign neoplasm of mesothelial tissue of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D199",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D200",
	 description = " Benign neoplasm of soft tissue of retroperitoneum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D201",
	 description = " Benign neoplasm of soft tissue of peritoneum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D210",
	 description = "Benign",
	 additional = "face and neck"
},
new ICD10
{
	 code = "D2110   Benign neoplasm of connective and other soft tissue of upper limb",
	 description = "including shoulder",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2111",
	 description = "Benign",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "D2112",
	 description = "Benign",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "D2120   Benign neoplasm of connective and other soft tissue of lower limb",
	 description = "including hip",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2121",
	 description = "Benign",
	 additional = "including hip"
},
new ICD10
{
	 code = "D2122",
	 description = "Benign",
	 additional = "including hip"
},
new ICD10
{
	 code = "D213",
	 description = " Benign neoplasm of connective and other soft tissue of thorax",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D214",
	 description = " Benign neoplasm of connective and other soft tissue of abdomen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D215",
	 description = " Benign neoplasm of connective and other soft tissue of pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D216",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D219",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D220",
	 description = " Melanocytic nevi of lip",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2210   Melanocytic nevi of eyelid",
	 description = "including canthus",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2211",
	 description = "Melanocytic",
	 additional = "including canthus"
},
new ICD10
{
	 code = "D2212",
	 description = "Melanocytic",
	 additional = "including canthus"
},
new ICD10
{
	 code = "D2220",
	 description = "Melanocytic",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2221",
	 description = " Melanocytic nevi of right ear and external auricular canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2222",
	 description = " Melanocytic nevi of left ear and external auricular canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2230",
	 description = " Melanocytic nevi of unspecified part of face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2239",
	 description = " Melanocytic nevi of other parts of face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D224",
	 description = " Melanocytic nevi of scalp and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D225",
	 description = " Melanocytic nevi of trunk",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2260   Melanocytic nevi of upper limb",
	 description = "including shoulder",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2261",
	 description = "Melanocytic",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "D2262",
	 description = "Melanocytic",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "D2270   Melanocytic nevi of lower limb",
	 description = "including hip",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2271",
	 description = "Melanocytic",
	 additional = "including hip"
},
new ICD10
{
	 code = "D2272",
	 description = "Melanocytic",
	 additional = "including hip"
},
new ICD10
{
	 code = "D229",
	 description = "Melanocytic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D230",
	 description = " Other benign neoplasm of skin of lip",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2310   Other benign neoplasm of skin of eyelid",
	 description = "including canthus",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2311",
	 description = "Other",
	 additional = "including canthus"
},
new ICD10
{
	 code = "D2312",
	 description = "Other",
	 additional = "including canthus"
},
new ICD10
{
	 code = "D2320",
	 description = "Other",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2321",
	 description = " Other benign neoplasm of skin of right ear and external auricular canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2322",
	 description = " Other benign neoplasm of skin of left ear and external auricular canal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2330",
	 description = " Other benign neoplasm of skin of unspecified part of face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2339",
	 description = " Other benign neoplasm of skin of other parts of face",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D234",
	 description = " Other benign neoplasm of skin of scalp and neck",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D235",
	 description = " Other benign neoplasm of skin of trunk",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2360   Other benign neoplasm of skin of upper limb",
	 description = "including shoulder",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2361",
	 description = "Other",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "D2362",
	 description = "Other",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "D2370   Other benign neoplasm of skin of lower limb",
	 description = "including hip",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2371",
	 description = "Other",
	 additional = "including hip"
},
new ICD10
{
	 code = "D2372",
	 description = "Other",
	 additional = "including hip"
},
new ICD10
{
	 code = "D239",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2400",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2401",
	 description = " Benign neoplasm of right female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2402",
	 description = " Benign neoplasm of left female breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2410",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2411",
	 description = " Benign neoplasm of right male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2412",
	 description = " Benign neoplasm of left male breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D250",
	 description = " Submucous leiomyoma of uterus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D251",
	 description = " Intramural leiomyoma of uterus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D252",
	 description = " Subserosal leiomyoma of uterus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D259",
	 description = "Leiomyoma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D260",
	 description = " Other benign neoplasm of cervix uteri",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D261",
	 description = " Other benign neoplasm of corpus uteri",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D267",
	 description = " Other benign neoplasm of other parts of uterus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D269",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D270",
	 description = " Benign neoplasm of right ovary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D271",
	 description = " Benign neoplasm of left ovary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D279",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D280",
	 description = " Benign neoplasm of vulva",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D281",
	 description = " Benign neoplasm of vagina",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D282",
	 description = " Benign neoplasm of uterine tubes and ligaments",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D287",
	 description = " Benign neoplasm of other specified female genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D289",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D290",
	 description = " Benign neoplasm of penis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D291",
	 description = " Benign neoplasm of prostate",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2920",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2921",
	 description = " Benign neoplasm of right testis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2922",
	 description = " Benign neoplasm of left testis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2930",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D2931",
	 description = " Benign neoplasm of right epididymis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D2932",
	 description = " Benign neoplasm of left epididymis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D294",
	 description = " Benign neoplasm of scrotum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D297",
	 description = " Benign neoplasm of other male genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D299",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3000",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3001",
	 description = " Benign neoplasm of right kidney",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3002",
	 description = " Benign neoplasm of left kidney",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3010",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3011",
	 description = " Benign neoplasm of right renal pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3012",
	 description = " Benign neoplasm of left renal pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3020",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3021",
	 description = " Benign neoplasm of right ureter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3022",
	 description = " Benign neoplasm of left ureter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D303",
	 description = " Benign neoplasm of bladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D304",
	 description = " Benign neoplasm of urethra",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D307",
	 description = " Benign neoplasm of other urinary organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D309",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3100",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3101",
	 description = " Benign neoplasm of right conjunctiva",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3102",
	 description = " Benign neoplasm of left conjunctiva",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3110",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3111",
	 description = " Benign neoplasm of right cornea",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3112",
	 description = " Benign neoplasm of left cornea",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3120",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3121",
	 description = " Benign neoplasm of right retina",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3122",
	 description = " Benign neoplasm of left retina",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3130",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3131",
	 description = " Benign neoplasm of right choroid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3132",
	 description = " Benign neoplasm of left choroid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3140",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3141",
	 description = " Benign neoplasm of right ciliary body",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3142",
	 description = " Benign neoplasm of left ciliary body",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3150",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3151",
	 description = " Benign neoplasm of right lacrimal gland and duct",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3152",
	 description = " Benign neoplasm of left lacrimal gland and duct",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3160   Benign neoplasm of orbit",
	 description = "unspecified",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3161",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3162",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3190   Benign neoplasm of eye",
	 description = "unspecified",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3191",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3192",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D320",
	 description = " Benign neoplasm of cerebral meninges",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D321",
	 description = " Benign neoplasm of spinal meninges",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D329",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D330",
	 description = "Benign",
	 additional = "supratentorial"
},
new ICD10
{
	 code = "D331",
	 description = "Benign",
	 additional = "infratentorial"
},
new ICD10
{
	 code = "D332",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D333",
	 description = " Benign neoplasm of cranial nerves",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D334",
	 description = " Benign neoplasm of spinal cord",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D337",
	 description = " Benign neoplasm of other specified parts of central nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D339",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D34",
	 description = " Benign neoplasm of thyroid gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3500",
	 description = "Benign",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3501",
	 description = " Benign neoplasm of right adrenal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3502",
	 description = " Benign neoplasm of left adrenal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D351",
	 description = " Benign neoplasm of parathyroid gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D352",
	 description = " Benign neoplasm of pituitary gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D353",
	 description = " Benign neoplasm of craniopharyngeal duct",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D354",
	 description = " Benign neoplasm of pineal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D355",
	 description = " Benign neoplasm of carotid body",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D356",
	 description = " Benign neoplasm of aortic body and other paraganglia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D357",
	 description = " Benign neoplasm of other specified endocrine glands",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D358",
	 description = " Benign neoplasm with pluriglandular involvement",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D359",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D360",
	 description = " Benign neoplasm of lymph nodes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3610",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3611   Benign neoplasm of peripheral nerves and autonomic nervous system of face",
	 description = "head",
	 additional = "and neck"
},
new ICD10
{
	 code = "D3612   Benign neoplasm of peripheral nerves and autonomic nervous system",
	 description = "upper limb",
	 additional = "including shoulder"
},
new ICD10
{
	 code = "D3613",
	 description = "Benign",
	 additional = "including hip"
},
new ICD10
{
	 code = "D3614",
	 description = " Benign neoplasm of peripheral nerves and autonomic nervous system of thorax",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3615",
	 description = " Benign neoplasm of peripheral nerves and autonomic nervous system of abdomen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3616",
	 description = " Benign neoplasm of peripheral nerves and autonomic nervous system of pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3617",
	 description = "Benign",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D367",
	 description = " Benign neoplasm of other specified sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D369",
	 description = "Benign",
	 additional = "unspecified site"
},
new ICD10
{
	 code = "D3701",
	 description = " Neoplasm of uncertain behavior of lip",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3702",
	 description = " Neoplasm of uncertain behavior of tongue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D37030",
	 description = " Neoplasm of uncertain behavior of the parotid salivary glands",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D37031",
	 description = " Neoplasm of uncertain behavior of the sublingual salivary glands",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D37032",
	 description = " Neoplasm of uncertain behavior of the submandibular salivary glands",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D37039",
	 description = "Neoplasm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3704",
	 description = " Neoplasm of uncertain behavior of the minor salivary glands",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3705",
	 description = " Neoplasm of uncertain behavior of pharynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3709",
	 description = " Neoplasm of uncertain behavior of other specified sites of the oral cavity",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D371",
	 description = " Neoplasm of uncertain behavior of stomach",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D372",
	 description = " Neoplasm of uncertain behavior of small intestine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D373",
	 description = " Neoplasm of uncertain behavior of appendix",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D374",
	 description = " Neoplasm of uncertain behavior of colon",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D375",
	 description = " Neoplasm of uncertain behavior of rectum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D376",
	 description = "Neoplasm",
	 additional = "gallbladder and bile ducts"
},
new ICD10
{
	 code = "D377",
	 description = " Neoplasm of uncertain behavior of other digestive organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D379",
	 description = "Neoplasm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D380",
	 description = " Neoplasm of uncertain behavior of larynx",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D381",
	 description = "Neoplasm",
	 additional = "bronchus and lung"
},
new ICD10
{
	 code = "D382",
	 description = " Neoplasm of uncertain behavior of pleura",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D383",
	 description = " Neoplasm of uncertain behavior of mediastinum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D384",
	 description = " Neoplasm of uncertain behavior of thymus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D385",
	 description = " Neoplasm of uncertain behavior of other respiratory organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D386",
	 description = "Neoplasm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D390",
	 description = " Neoplasm of uncertain behavior of uterus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3910",
	 description = "Neoplasm",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D3911",
	 description = " Neoplasm of uncertain behavior of right ovary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D3912",
	 description = " Neoplasm of uncertain behavior of left ovary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D392",
	 description = " Neoplasm of uncertain behavior of placenta",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D397",
	 description = " Neoplasm of uncertain behavior of other female genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D399",
	 description = "Neoplasm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D400",
	 description = " Neoplasm of uncertain behavior of prostate",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4010",
	 description = "Neoplasm",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D4011",
	 description = " Neoplasm of uncertain behavior of right testis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4012",
	 description = " Neoplasm of uncertain behavior of left testis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D407",
	 description = " Neoplasm of uncertain behavior of other male genital organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D409",
	 description = "Neoplasm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4100",
	 description = "Neoplasm",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D4101",
	 description = " Neoplasm of uncertain behavior of right kidney",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4102",
	 description = " Neoplasm of uncertain behavior of left kidney",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4110",
	 description = "Neoplasm",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D4111",
	 description = " Neoplasm of uncertain behavior of right renal pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4112",
	 description = " Neoplasm of uncertain behavior of left renal pelvis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4120",
	 description = "Neoplasm",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D4121",
	 description = " Neoplasm of uncertain behavior of right ureter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4122",
	 description = " Neoplasm of uncertain behavior of left ureter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D413",
	 description = " Neoplasm of uncertain behavior of urethra",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D414",
	 description = " Neoplasm of uncertain behavior of bladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D417",
	 description = " Neoplasm of uncertain behavior of other urinary organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D419",
	 description = "Neoplasm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D420",
	 description = " Neoplasm of uncertain behavior of cerebral meninges",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D421",
	 description = " Neoplasm of uncertain behavior of spinal meninges",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D429",
	 description = "Neoplasm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D430",
	 description = "Neoplasm",
	 additional = "supratentorial"
},
new ICD10
{
	 code = "D431",
	 description = "Neoplasm",
	 additional = "infratentorial"
},
new ICD10
{
	 code = "D432",
	 description = "Neoplasm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D433",
	 description = " Neoplasm of uncertain behavior of cranial nerves",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D434",
	 description = " Neoplasm of uncertain behavior of spinal cord",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D437",
	 description = " Neoplasm of uncertain behavior of other parts of central nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D439",
	 description = "Neoplasm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D440",
	 description = " Neoplasm of uncertain behavior of thyroid gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4410",
	 description = "Neoplasm",
	 additional = "unspecified side"
},
new ICD10
{
	 code = "D4411",
	 description = " Neoplasm of uncertain behavior of right adrenal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4412",
	 description = " Neoplasm of uncertain behavior of left adrenal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D442",
	 description = " Neoplasm of uncertain behavior of parathyroid gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D443",
	 description = " Neoplasm of uncertain behavior of pituitary gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D444",
	 description = " Neoplasm of uncertain behavior of craniopharyngeal duct",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D445",
	 description = " Neoplasm of uncertain behavior of pineal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D446",
	 description = " Neoplasm of uncertain behavior of carotid body",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D447",
	 description = " Neoplasm of uncertain behavior of aortic body and other paraganglia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D448",
	 description = " Neoplasm of uncertain behavior with pluriglandular involvement",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D449",
	 description = "Neoplasm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D45",
	 description = " Polycythemia vera",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D460",
	 description = "Refractory",
	 additional = "so stated"
},
new ICD10
{
	 code = "D461",
	 description = " Refractory anemia with (ringed) sideroblasts",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4620",
	 description = "Refractory",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4621",
	 description = " Refractory anemia with excess blasts 1",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4622",
	 description = " Refractory anemia with excess blasts 2",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D463",
	 description = " Refractory anemia with excess blasts in transformation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D464",
	 description = "Refractory",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4671",
	 description = " Refractory cytopenia with multilineage dysplasia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4672",
	 description = " Refractory cytopenia with multilineage dysplasia and ringed sideroblasts",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4673",
	 description = " Myelodysplastic syndrome with 5q deletion",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4679",
	 description = " Other myelodysplastic syndromes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D469",
	 description = "Myelodysplastic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D470",
	 description = " Histiocytic and mast cell tumors of uncertain behavior",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D471",
	 description = " Chronic myeloproliferative disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D472",
	 description = " Monoclonal gammopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D473",
	 description = " Essential (hemorrhagic) thrombocythemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D477",
	 description = "Other",
	 additional = "hematopoietic and related tissue"
},
new ICD10
{
	 code = "D479    Neoplasm of uncertain behavior of lymphoid",
	 description = "hematopoietic and related tissue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D480",
	 description = " Neoplasm of uncertain behavior of bone and articular cartilage",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D481",
	 description = " Neoplasm of uncertain behavior of connective and other soft tissue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D482",
	 description = " Neoplasm of uncertain behavior of peripheral nerves and autonomic nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D483",
	 description = " Neoplasm of uncertain behavior of retroperitoneum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D484",
	 description = " Neoplasm of uncertain behavior of peritoneum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D485",
	 description = " Neoplasm of uncertain behavior of skin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4861",
	 description = " Neoplasm of uncertain behavior of right breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4862",
	 description = " Neoplasm of uncertain behavior of left breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D4869",
	 description = " Neoplasm of uncertain behavior of unspecified breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D487",
	 description = " Neoplasm of uncertain behavior of other specified sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D489",
	 description = "Neoplasm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D490",
	 description = " Neoplasm of unspecified behavior of digestive system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D491",
	 description = " Neoplasm of unspecified behavior of respiratory system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D492    Neoplasm of unspecified behavior of bone",
	 description = "soft tissue",
	 additional = "and skin"
},
new ICD10
{
	 code = "D493",
	 description = " Neoplasm of unspecified behavior of breast",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D494",
	 description = " Neoplasm of unspecified behavior of bladder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D495",
	 description = " Neoplasm of unspecified behavior of other genitourinary organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D496",
	 description = " Neoplasm of unspecified behavior of brain",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D497",
	 description = " Neoplasm of unspecified behavior of endocrine glands and other parts of nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D498",
	 description = " Neoplasm of unspecified behavior of other specified sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D499",
	 description = " Neoplasm of unspecified behavior of unspecified site",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D500",
	 description = " Iron deficiency anemia secondary to blood loss (chronic)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D501",
	 description = " Sideropenic dysphagia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D508",
	 description = " Other iron deficiency anemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D509",
	 description = "Iron",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D510",
	 description = " Vitamin B12 deficiency anemia due to intrinsic factor deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D511",
	 description = " Vitamin B12 deficiency anemia due to selective vitamin B12 malabsorption with proteinuria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D512",
	 description = " Transcobalamin II deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D513",
	 description = " Other dietary vitamin B12 deficiency anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D518",
	 description = " Other vitamin B12 deficiency anemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D519",
	 description = "Vitamin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D520",
	 description = " Dietary folate deficiency anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D521",
	 description = " Drug-induced folate deficiency anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D528",
	 description = " Other folate deficiency anemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D529",
	 description = "Folate",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D530",
	 description = " Protein deficiency anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D531",
	 description = "Other",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "D532",
	 description = " Scorbutic anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D538",
	 description = " Other specified nutritional anemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D539",
	 description = "Nutritional",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D550",
	 description = " Anemia due to glucose-6-phosphate dehydrogenase [G6PD] deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D551",
	 description = " Anemia due to other disorders of glutathione metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D552",
	 description = " Anemia due to disorders of glycolytic enzymes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D553",
	 description = " Anemia due to disorders of nucleotide metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D558",
	 description = " Other anemias due to enzyme disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D559",
	 description = "Anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D560",
	 description = " Alpha thalassemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D561",
	 description = " Beta thalassemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D562",
	 description = " Delta-beta thalassemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D563",
	 description = " Thalassemia minor",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D564",
	 description = " Hereditary persistence of fetal hemoglobin [HPFH]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D568",
	 description = " Other thalassemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D569",
	 description = "Thalassemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D5700",
	 description = "Hb-SS",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D5701",
	 description = " Hb-SS disease with acute chest syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D5702",
	 description = " Hb-SS disease with splenic sequestration",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D571",
	 description = " Sickle-cell disease without crisis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D5720",
	 description = " Sickle-cell/Hb-C disease without crisis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D57211",
	 description = " Sickle-cell/Hb-C disease with acute chest syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D57212",
	 description = " Sickle-cell/Hb-C disease with splenic sequestration",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D57219",
	 description = "Sickle-cell/Hb-C",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D573",
	 description = " Sickle-cell trait",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D5740",
	 description = " Sickle-cell thalassemia without crisis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D57411",
	 description = " Sickle-cell thalassemia with acute chest syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D57412",
	 description = " Sickle-cell thalassemia with splenic sequestration",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D57419",
	 description = "Sickle-cell",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D5780",
	 description = " Other sickle-cell disorders without crisis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D57811",
	 description = " Other sickle-cell disorders with acute chest syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D57812",
	 description = " Other sickle-cell disorders with splenic sequestration",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D57819",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D580",
	 description = " Hereditary spherocytosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D581",
	 description = " Hereditary elliptocytosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D582",
	 description = " Other hemoglobinopathies",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D588",
	 description = " Other specified hereditary hemolytic anemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D589",
	 description = "Hereditary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D590",
	 description = " Drug-induced autoimmune hemolytic anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D591",
	 description = " Other autoimmune hemolytic anemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D592",
	 description = " Drug-induced nonautoimmune hemolytic anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D593",
	 description = " Hemolytic-uremic syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D594",
	 description = " Other nonautoimmune hemolytic anemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D595",
	 description = " Paroxysmal nocturnal hemoglobinuria [Marchiafava-Micheli]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D596",
	 description = " Hemoglobinuria due to hemolysis from other external causes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D598",
	 description = " Other acquired hemolytic anemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D599",
	 description = "Acquired",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D600",
	 description = " Chronic acquired pure red cell aplasia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D601",
	 description = " Transient acquired pure red cell aplasia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D608",
	 description = " Other acquired pure red cell aplasias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D609",
	 description = "Acquired",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6101",
	 description = " Constitutional (pure) red blood cell aplasia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6109",
	 description = " Other constitutional aplastic anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D611",
	 description = " Drug-induced aplastic anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D612",
	 description = " Aplastic anemia due to other external agents",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D613",
	 description = " Idiopathic aplastic anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6181",
	 description = " Pancytopenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6182",
	 description = " Myelophthisis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6189",
	 description = " Other specified aplastic anemias and other bone marrow failure syndromes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D619",
	 description = "Aplastic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D62",
	 description = " Acute posthemorrhagic anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D630",
	 description = " Anemia in neoplastic disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D631",
	 description = " Anemia in chronic kidney disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D638",
	 description = " Anemia in other chronic diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D640",
	 description = " Hereditary sideroblastic anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D641",
	 description = " Secondary sideroblastic anemia due to disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D642",
	 description = " Secondary sideroblastic anemia due to drugs and toxins",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D643",
	 description = " Other sideroblastic anemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D644",
	 description = " Congenital dyserythropoietic anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D648",
	 description = " Other specified anemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D649",
	 description = "Anemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D65",
	 description = " Disseminated intravascular coagulation [defibrination syndrome]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D66",
	 description = " Hereditary factor VIII deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D67",
	 description = " Hereditary factor IX deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D680",
	 description = " Von Willebrand's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D681",
	 description = " Hereditary factor XI deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D682",
	 description = " Hereditary deficiency of other clotting factors",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6831",
	 description = " Hemorrhagic disorder due to intrinsic circulating anticoagulants",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6832",
	 description = " Hemorrhagic disorder due to extrinsic circulating anticoagulants",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D684",
	 description = " Acquired coagulation factor deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6851",
	 description = " Activated protein C resistance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6852",
	 description = " Prothrombin gene mutation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6859",
	 description = " Other primary thrombophilia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6861",
	 description = " Anticardiolipin syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6862",
	 description = " Lupus anticoagulant syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6869",
	 description = " Other thrombophilia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D688",
	 description = " Other specified coagulation defects",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D689",
	 description = "Coagulation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D690",
	 description = " Allergic purpura",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D691",
	 description = " Qualitative platelet defects",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D692",
	 description = " Other nonthrombocytopenic purpura",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D693",
	 description = " Immune thrombocytopenic purpura",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6941",
	 description = " Evans syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6942",
	 description = " Congenital and hereditary thrombocytopenia purpura",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D6949",
	 description = " Other primary thrombocytopenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D695",
	 description = " Secondary thrombocytopenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D696",
	 description = "Thrombocytopenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D698",
	 description = " Other specified hemorrhagic conditions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D699",
	 description = "Hemorrhagic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D700",
	 description = " Congenital agranulocytosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D701",
	 description = " Agranulocytosis secondary to cancer chemotherapy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D702",
	 description = " Other drug-induced agranulocytosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D703",
	 description = " Neutropenia due to infection",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D704",
	 description = " Cyclic neutropenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D708",
	 description = " Other neutropenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D709",
	 description = "Neutropenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D71",
	 description = " Functional disorders of polymorphonuclear neutrophils",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D720",
	 description = " Genetic anomalies of leukocytes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D721",
	 description = " Eosinophilia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D72810",
	 description = " Lymphocytopenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D72818",
	 description = " Other decreased white blood cell count",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D72819",
	 description = "Decreased",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D72820",
	 description = " Lymphocytosis (symptomatic)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D72821",
	 description = " Monocytosis (symptomatic)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D72822",
	 description = " Plasmacytosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D72823",
	 description = " Leukemoid reaction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D72824",
	 description = " Basophilia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D72825",
	 description = " Bandemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D72828",
	 description = " Other elevated white blood cell count",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D72829",
	 description = "Elevated",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7289",
	 description = " Other specified disorders of white blood cells",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D729",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D730",
	 description = " Hyposplenism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D731",
	 description = " Hypersplenism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D732",
	 description = " Chronic congestive splenomegaly",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D733",
	 description = " Abscess of spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D734",
	 description = " Cyst of spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D735",
	 description = " Infarction of spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7381",
	 description = " Neutropenic splenomegaly",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7389",
	 description = " Other diseases of spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D739",
	 description = "Disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D740",
	 description = " Congenital methemoglobinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D748",
	 description = " Other methemoglobinemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D749",
	 description = "Methemoglobinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D750",
	 description = " Familial erythrocytosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D751",
	 description = " Secondary polycythemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D752",
	 description = " Essential thrombocytosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7581",
	 description = " Myelofibrosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7589",
	 description = " Other specified diseases of blood and blood-forming organs",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D759",
	 description = "Disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D760",
	 description = "Langerhans'",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "D761",
	 description = " Hemophagocytic lymphohistiocytosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D762",
	 description = "Hemophagocytic",
	 additional = "infection-associated"
},
new ICD10
{
	 code = "D763",
	 description = " Other histiocytosis syndromes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D77",
	 description = " Other disorders of blood and blood-forming organs in diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7801",
	 description = " Intraoperative hemorrhage and hematoma of spleen complicating a procedure on the spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7802",
	 description = " Intraoperative hemorrhage and hematoma of spleen complicating other procedure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7811",
	 description = " Accidental puncture and laceration of spleen during a procedure on the spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7812",
	 description = " Accidental puncture and laceration of spleen during other procedure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7821",
	 description = " Postprocedural hemorrhage and hematoma of spleen following a procedure on the spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7822",
	 description = " Postprocedural hemorrhage and hematoma of spleen following other procedure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7881",
	 description = " Other intraoperative complications of spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D7889",
	 description = " Other postprocedural complications of spleen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D800",
	 description = " Hereditary hypogammaglobulinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D801",
	 description = " Nonfamilial hypogammaglobulinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D802",
	 description = " Selective deficiency of immunoglobulin A [IgA]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D803",
	 description = " Selective deficiency of immunoglobulin G [IgG] subclasses",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D804",
	 description = " Selective deficiency of immunoglobulin M [IgM]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D805",
	 description = " Immunodeficiency with increased immunoglobulin M [IgM]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D806",
	 description = " Antibody deficiency with near-normal immunoglobulins or with hyperimmunoglobulinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D807",
	 description = " Transient hypogammaglobulinemia of infancy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D808",
	 description = " Other immunodeficiencies with predominantly antibody defects",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D809",
	 description = "Immunodeficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D810",
	 description = " Severe combined immunodeficiency [SCID] with reticular dysgenesis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D811",
	 description = " Severe combined immunodeficiency [SCID] with low T- and B-cell numbers",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D812",
	 description = " Severe combined immunodeficiency [SCID] with low or normal B-cell numbers",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D813",
	 description = " Adenosine deaminase [ADA] deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D814",
	 description = " Nezelof's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D815",
	 description = " Purine nucleoside phosphorylase [PNP] deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D816",
	 description = " Major histocompatibility complex class I deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D817",
	 description = " Major histocompatibility complex class II deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D81810",
	 description = " Biotinidase deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D81818",
	 description = " Other biotin-dependent carboxylase deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D81819",
	 description = "Biotin-dependent",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D8189",
	 description = " Other combined immunodeficiencies",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D819",
	 description = "Combined",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D820",
	 description = " Wiskott-Aldrich syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D821",
	 description = " Di George's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D822",
	 description = " Immunodeficiency with short-limbed stature",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D823",
	 description = " Immunodeficiency following hereditary defective response to Epstein-Barr virus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D824",
	 description = " Hyperimmunoglobulin E [IgE] syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D828",
	 description = " Immunodeficiency associated with other specified major defects",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D829",
	 description = "Immunodeficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D830",
	 description = " Common variable immunodeficiency with predominant abnormalities of B-cell numbers and function",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D831",
	 description = " Common variable immunodeficiency with predominant immunoregulatory T-cell disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D832",
	 description = " Common variable immunodeficiency with autoantibodies to B- or T-cells",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D838",
	 description = " Other common variable immunodeficiencies",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D839",
	 description = "Common",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D840",
	 description = " Lymphocyte function antigen-1 [LFA-1] defect",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D841",
	 description = " Defects in the complement system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D848",
	 description = " Other specified immunodeficiencies",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D849",
	 description = "Immunodeficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D860",
	 description = " Sarcoidosis of lung",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D861",
	 description = " Sarcoidosis of lymph nodes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D862",
	 description = " Sarcoidosis of lung with sarcoidosis of lymph nodes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D863",
	 description = " Sarcoidosis of skin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D8681",
	 description = " Sarcoid meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D8682",
	 description = " Multiple cranial nerve palsies in sarcoidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D8683",
	 description = " Sarcoid iridocyclitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D8684",
	 description = " Sarcoid pyelonephritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D8685",
	 description = " Sarcoid myocarditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D8686",
	 description = " Sarcoid arthropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D8687",
	 description = " Sarcoid myositis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D8689",
	 description = " Sarcoidosis of other sites",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D869",
	 description = "Sarcoidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D890",
	 description = " Polyclonal hypergammaglobulinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D891",
	 description = " Cryoglobulinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D892",
	 description = "Hypergammaglobulinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "D898",
	 description = "Other",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "D899",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E000",
	 description = "Congenital",
	 additional = "neurological type"
},
new ICD10
{
	 code = "E001",
	 description = "Congenital",
	 additional = "myxedematous type"
},
new ICD10
{
	 code = "E002",
	 description = "Congenital",
	 additional = "mixed type"
},
new ICD10
{
	 code = "E009",
	 description = "Congenital",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E010",
	 description = " Iodine-deficiency related diffuse (endemic) goiter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E011",
	 description = " Iodine-deficiency related multinodular (endemic) goiter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E012",
	 description = "Iodine-deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E018",
	 description = " Other iodine-deficiency related thyroid disorders and allied conditions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E02",
	 description = " Subclinical iodine-deficiency hypothyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E030",
	 description = " Congenital hypothyroidism with diffuse goiter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E031",
	 description = " Congenital hypothyroidism without goiter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E032",
	 description = " Hypothyroidism due to medicaments and other exogenous substances",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E033",
	 description = " Postinfectious hypothyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E034",
	 description = " Atrophy of thyroid (acquired)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E035",
	 description = " Myxedema coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E038",
	 description = " Other specified hypothyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E039",
	 description = "Hypothyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E040",
	 description = " Nontoxic diffuse goiter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E041",
	 description = " Nontoxic single thyroid nodule",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E042",
	 description = " Nontoxic multinodular goiter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E048",
	 description = " Other specified nontoxic goiter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E049",
	 description = "Nontoxic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0500",
	 description = " Thyrotoxicosis with diffuse goiter without thyrotoxic crisis or storm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0501",
	 description = " Thyrotoxicosis with diffuse goiter with thyrotoxic crisis or storm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0510",
	 description = " Thyrotoxicosis with toxic single thyroid nodule without thyrotoxic crisis or storm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0511",
	 description = " Thyrotoxicosis with toxic single thyroid nodule with thyrotoxic crisis or storm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0520",
	 description = " Thyrotoxicosis with toxic multinodular goiter without thyrotoxic crisis or storm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0521",
	 description = " Thyrotoxicosis with toxic multinodular goiter with thyrotoxic crisis or storm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0530",
	 description = " Thyrotoxicosis from ectopic thyroid tissue without thyrotoxic crisis or storm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0531",
	 description = " Thyrotoxicosis from ectopic thyroid tissue with thyrotoxic crisis or storm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0540",
	 description = " Thyrotoxicosis factitia without thyrotoxic crisis or storm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0541",
	 description = " Thyrotoxicosis factitia with thyrotoxic crisis or storm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0580",
	 description = " Other thyrotoxicosis without thyrotoxic crisis or storm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0581",
	 description = " Other thyrotoxicosis with thyrotoxic crisis or storm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0590",
	 description = "Thyrotoxicosis",
	 additional = "unspecified without thyrotoxic crisis or storm"
},
new ICD10
{
	 code = "E0591",
	 description = "Thyrotoxicosis",
	 additional = "unspecified with thyrotoxic crisis or storm"
},
new ICD10
{
	 code = "E060",
	 description = " Acute thyroiditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E061",
	 description = " Subacute thyroiditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E062",
	 description = " Chronic thyroiditis with transient thyrotoxicosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E063",
	 description = " Autoimmune thyroiditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E064",
	 description = " Drug-induced thyroiditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E065",
	 description = " Other chronic thyroiditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E069",
	 description = "Thyroiditis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E070",
	 description = " Hypersecretion of calcitonin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E071",
	 description = " Dyshormogenetic goiter",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0781",
	 description = " Sick-euthyroid syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0789",
	 description = " Other specified disorders of thyroid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E079",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0800",
	 description = " Diabetes mellitus due to underlying condition with hyperosmolarity without nonketotic hyperglycemic-hyperosmolar coma (NKHHC)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0801",
	 description = " Diabetes mellitus due to underlying condition with hyperosmolarity with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0810",
	 description = " Diabetes mellitus due to underlying condition with ketoacidosis without coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0811",
	 description = " Diabetes mellitus due to underlying condition with ketoacidosis with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0821",
	 description = " Diabetes mellitus due to underlying condition with diabetic nephropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0822",
	 description = " Diabetes mellitus due to underlying condition with diabetic chronic kidney disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0829",
	 description = " Diabetes mellitus due to underlying condition with other diabetic kidney complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08311",
	 description = " Diabetes mellitus due to underlying condition with unspecified diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08319",
	 description = " Diabetes mellitus due to underlying condition with unspecified diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08321",
	 description = " Diabetes mellitus due to underlying condition with mild nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08329",
	 description = " Diabetes mellitus due to underlying condition with mild nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08331",
	 description = " Diabetes mellitus due to underlying condition with moderate nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08339",
	 description = " Diabetes mellitus due to underlying condition with moderate nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08341",
	 description = " Diabetes mellitus due to underlying condition with severe nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08349",
	 description = " Diabetes mellitus due to underlying condition with severe nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08351",
	 description = " Diabetes mellitus due to underlying condition with proliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08359",
	 description = " Diabetes mellitus due to underlying condition with proliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0836",
	 description = " Diabetes mellitus due to underlying condition with diabetic cataract",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0839",
	 description = " Diabetes mellitus due to underlying condition with other diabetic ophthalmic complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0840",
	 description = "Diabetes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0841",
	 description = " Diabetes mellitus due to underlying condition with diabetic mononeuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0842",
	 description = " Diabetes mellitus due to underlying condition with diabetic polyneuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0843",
	 description = " Diabetes mellitus due to underlying condition with diabetic autonomic (poly)neuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0844",
	 description = " Diabetes mellitus due to underlying condition with diabetic amyotrophy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0849",
	 description = " Diabetes mellitus due to underlying condition with other diabetic neurological complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0851",
	 description = " Diabetes mellitus due to underlying condition with diabetic peripheral angiopathy without gangrene",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0852",
	 description = " Diabetes mellitus due to underlying condition with diabetic peripheral angiopathy with gangrene",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0859",
	 description = " Diabetes mellitus due to underlying condition with other circulatory complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08610",
	 description = " Diabetes mellitus due to underlying condition with diabetic neuropathic arthropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08618",
	 description = " Diabetes mellitus due to underlying condition with other diabetic arthropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08620",
	 description = " Diabetes mellitus due to underlying condition with diabetic dermatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08621",
	 description = " Diabetes mellitus due to underlying condition with foot ulcer",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08622",
	 description = " Diabetes mellitus due to underlying condition with other skin ulcer",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08628",
	 description = " Diabetes mellitus due to underlying condition with other skin complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08630",
	 description = " Diabetes mellitus due to underlying condition with periodontal disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08638",
	 description = " Diabetes mellitus due to underlying condition with other oral complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08640",
	 description = " Diabetes mellitus due to underlying condition with hypoglycemia without coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E08641",
	 description = " Diabetes mellitus due to underlying condition with hypoglycemia with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0865",
	 description = " Diabetes mellitus due to underlying condition with hyperglycemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0869",
	 description = " Diabetes mellitus due to underlying condition with other specified complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E088",
	 description = " Diabetes mellitus due to underlying condition with unspecified complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E089",
	 description = " Diabetes mellitus due to underlying condition without complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0900",
	 description = " Drug or chemical induced diabetes mellitus with hyperosmolarity without nonketotic hyperglycemic-hyperosmolar coma (NKHHC)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0901",
	 description = " Drug or chemical induced diabetes mellitus with hyperosmolarity with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0910",
	 description = " Drug or chemical induced diabetes mellitus with ketoacidosis without coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0911",
	 description = " Drug or chemical induced diabetes mellitus with ketoacidosis with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0921",
	 description = " Drug or chemical induced diabetes mellitus with diabetic nephropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0922",
	 description = " Drug or chemical induced diabetes mellitus with diabetic chronic kidney disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0929",
	 description = " Drug or chemical induced diabetes mellitus with other diabetic kidney complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09311",
	 description = " Drug or chemical induced diabetes mellitus with unspecified diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09319",
	 description = " Drug or chemical induced diabetes mellitus with unspecified diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09321",
	 description = " Drug or chemical induced diabetes mellitus with mild nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09329",
	 description = " Drug or chemical induced diabetes mellitus with mild nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09331",
	 description = " Drug or chemical induced diabetes mellitus with moderate nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09339",
	 description = " Drug or chemical induced diabetes mellitus with moderate nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09341",
	 description = " Drug or chemical induced diabetes mellitus with severe nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09349",
	 description = " Drug or chemical induced diabetes mellitus with severe nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09351",
	 description = " Drug or chemical induced diabetes mellitus with proliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09359",
	 description = " Drug or chemical induced diabetes mellitus with proliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0936",
	 description = " Drug or chemical induced diabetes mellitus with diabetic cataract",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0939",
	 description = " Drug or chemical induced diabetes mellitus with other diabetic ophthalmic complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0940",
	 description = "Drug",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0941",
	 description = " Drug or chemical induced diabetes mellitus with neurological complications with diabetic mononeuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0942",
	 description = " Drug or chemical induced diabetes mellitus with neurological complications with diabetic polyneuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0943",
	 description = " Drug or chemical induced diabetes mellitus with neurological complications with diabetic autonomic (poly)neuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0944",
	 description = " Drug or chemical induced diabetes mellitus with neurological complications with diabetic amyotrophy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0949",
	 description = " Drug or chemical induced diabetes mellitus with neurological complications with other diabetic neurological complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0951",
	 description = " Drug or chemical induced diabetes mellitus with diabetic peripheral angiopathy without gangrene",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0952",
	 description = " Drug or chemical induced diabetes mellitus with diabetic peripheral angiopathy with gangrene",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0959",
	 description = " Drug or chemical induced diabetes mellitus with other circulatory complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09610",
	 description = " Drug or chemical induced diabetes mellitus with diabetic neuropathic arthropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09618",
	 description = " Drug or chemical induced diabetes mellitus with other diabetic arthropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09620",
	 description = " Drug or chemical induced diabetes mellitus with diabetic dermatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09621",
	 description = " Drug or chemical induced diabetes mellitus with foot ulcer",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09622",
	 description = " Drug or chemical induced diabetes mellitus with other skin ulcer",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09628",
	 description = " Drug or chemical induced diabetes mellitus with other skin complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09630",
	 description = " Drug or chemical induced diabetes mellitus with periodontal disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09638",
	 description = " Drug or chemical induced diabetes mellitus with other oral complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09640",
	 description = " Drug or chemical induced diabetes mellitus with hypoglycemia without coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E09641",
	 description = " Drug or chemical induced diabetes mellitus with hypoglycemia with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0965",
	 description = " Drug or chemical induced diabetes mellitus with hyperglycemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E0969",
	 description = " Drug or chemical induced diabetes mellitus with other specified complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E098",
	 description = " Drug or chemical induced diabetes mellitus with unspecified complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E099",
	 description = " Drug or chemical induced diabetes mellitus without complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1010",
	 description = " Type 1 diabetes mellitus with ketoacidosis without coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1011",
	 description = " Type 1 diabetes mellitus with ketoacidosis with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1021",
	 description = " Type 1 diabetes mellitus with diabetic nephropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1022",
	 description = " Type 1 diabetes mellitus with diabetic chronic kidney disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1029",
	 description = " Type 1 diabetes mellitus with other diabetic kidney complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10311",
	 description = " Type 1 diabetes mellitus with unspecified diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10319",
	 description = " Type 1 diabetes mellitus with unspecified diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10321",
	 description = " Type 1 diabetes mellitus with mild nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10329",
	 description = " Type 1 diabetes mellitus with mild nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10331",
	 description = " Type 1 diabetes mellitus with moderate nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10339",
	 description = " Type 1 diabetes mellitus with moderate nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10341",
	 description = " Type 1 diabetes mellitus with severe nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10349",
	 description = " Type 1 diabetes mellitus with severe nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10351",
	 description = " Type 1 diabetes mellitus with proliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10359",
	 description = " Type 1 diabetes mellitus with proliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1036",
	 description = " Type 1 diabetes mellitus with diabetic cataract",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1039",
	 description = " Type 1 diabetes mellitus with other diabetic ophthalmic complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1040",
	 description = "Type",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1041",
	 description = " Type 1 diabetes mellitus with diabetic mononeuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1042",
	 description = " Type 1 diabetes mellitus with diabetic polyneuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1043",
	 description = " Type 1 diabetes mellitus with diabetic autonomic (poly)neuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1044",
	 description = " Type 1 diabetes mellitus with diabetic amyotrophy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1049",
	 description = " Type 1 diabetes mellitus with other diabetic neurological complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1051",
	 description = " Type 1 diabetes mellitus with diabetic peripheral angiopathy without gangrene",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1052",
	 description = " Type 1 diabetes mellitus with diabetic peripheral angiopathy with gangrene",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1059",
	 description = " Type 1 diabetes mellitus with other circulatory complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10610",
	 description = " Type 1 diabetes mellitus with diabetic neuropathic arthropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10618",
	 description = " Type 1 diabetes mellitus with other diabetic arthropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10620",
	 description = " Type 1 diabetes mellitus with diabetic dermatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10621",
	 description = " Type 1 diabetes mellitus with foot ulcer",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10622",
	 description = " Type 1 diabetes mellitus with other skin ulcer",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10628",
	 description = " Type 1 diabetes mellitus with other skin complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10630",
	 description = " Type 1 diabetes mellitus with periodontal disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10638",
	 description = " Type 1 diabetes mellitus with other oral complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10640",
	 description = " Type 1 diabetes mellitus with hypoglycemia without coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E10641",
	 description = " Type 1 diabetes mellitus with hypoglycemia with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1065",
	 description = " Type 1 diabetes mellitus with hyperglycemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1069",
	 description = " Type 1 diabetes mellitus with other specified complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E108",
	 description = " Type 1 diabetes mellitus with unspecified complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E109",
	 description = " Type 1 diabetes mellitus without complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1100",
	 description = " Type 2 diabetes mellitus with hyperosmolarity without nonketotic hyperglycemic-hyperosmolar coma (NKHHC)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1101",
	 description = " Type 2 diabetes mellitus with hyperosmolarity with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1121",
	 description = " Type 2 diabetes mellitus with diabetic nephropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1122",
	 description = " Type 2 diabetes mellitus with diabetic chronic kidney disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1129",
	 description = " Type 2 diabetes mellitus with other diabetic kidney complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11311",
	 description = " Type 2 diabetes mellitus with unspecified diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11319",
	 description = " Type 2 diabetes mellitus with unspecified diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11321",
	 description = " Type 2 diabetes mellitus with mild nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11329",
	 description = " Type 2 diabetes mellitus with mild nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11331",
	 description = " Type 2 diabetes mellitus with moderate nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11339",
	 description = " Type 2 diabetes mellitus with moderate nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11341",
	 description = " Type 2 diabetes mellitus with severe nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11349",
	 description = " Type 2 diabetes mellitus with severe nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11351",
	 description = " Type 2 diabetes mellitus with proliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11359",
	 description = " Type 2 diabetes mellitus with proliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1136",
	 description = " Type 2 diabetes mellitus with diabetic cataract",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1139",
	 description = " Type 2 diabetes mellitus with other diabetic ophthalmic complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1140",
	 description = "Type",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1141",
	 description = " Type 2 diabetes mellitus with diabetic mononeuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1142",
	 description = " Type 2 diabetes mellitus with diabetic polyneuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1143",
	 description = " Type 2 diabetes mellitus with diabetic autonomic (poly)neuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1144",
	 description = " Type 2 diabetes mellitus with diabetic amyotrophy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1149",
	 description = " Type 2 diabetes mellitus with other diabetic neurological complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1151",
	 description = " Type 2 diabetes mellitus with diabetic peripheral angiopathy without gangrene",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1152",
	 description = " Type 2 diabetes mellitus with diabetic peripheral angiopathy with gangrene",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1159",
	 description = " Type 2 diabetes mellitus with other circulatory complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11610",
	 description = " Type 2 diabetes mellitus with diabetic neuropathic arthropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11618",
	 description = " Type 2 diabetes mellitus with other diabetic arthropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11620",
	 description = " Type 2 diabetes mellitus with diabetic dermatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11621",
	 description = " Type 2 diabetes mellitus with foot ulcer",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11622",
	 description = " Type 2 diabetes mellitus with other skin ulcer",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11628",
	 description = " Type 2 diabetes mellitus with other skin complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11630",
	 description = " Type 2 diabetes mellitus with periodontal disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11638",
	 description = " Type 2 diabetes mellitus with other oral complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11640",
	 description = " Type 2 diabetes mellitus with hypoglycemia without coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E11641",
	 description = " Type 2 diabetes mellitus with hypoglycemia with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1165",
	 description = " Type 2 diabetes mellitus with hyperglycemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1169",
	 description = " Type 2 diabetes mellitus with other specified complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E118",
	 description = " Type 2 diabetes mellitus with unspecified complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E119",
	 description = " Type 2 diabetes mellitus without complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1300",
	 description = " Other specified diabetes mellitus with hyperosmolarity without nonketotic hyperglycemic-hyperosmolar coma (NKHHC)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1301",
	 description = " Other specified diabetes mellitus with hyperosmolarity with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1310",
	 description = " Other specified diabetes mellitus with ketoacidosis without coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1311",
	 description = " Other specified diabetes mellitus with ketoacidosis with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1321",
	 description = " Other specified diabetes mellitus with diabetic nephropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1322",
	 description = " Other specified diabetes mellitus with diabetic chronic kidney disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1329",
	 description = " Other specified diabetes mellitus with other diabetic kidney complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13311",
	 description = " Other specified diabetes mellitus with unspecified diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13319",
	 description = " Other specified diabetes mellitus with unspecified diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13321",
	 description = " Other specified diabetes mellitus with mild nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13329",
	 description = " Other specified diabetes mellitus with mild nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13331",
	 description = " Other specified diabetes mellitus with moderate nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13339",
	 description = " Other specified diabetes mellitus with moderate nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13341",
	 description = " Other specified diabetes mellitus with severe nonproliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13349",
	 description = " Other specified diabetes mellitus with severe nonproliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13351",
	 description = " Other specified diabetes mellitus with proliferative diabetic retinopathy with macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13359",
	 description = " Other specified diabetes mellitus with proliferative diabetic retinopathy without macular edema",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1336",
	 description = " Other specified diabetes mellitus with diabetic cataract",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1339",
	 description = " Other specified diabetes mellitus with other diabetic ophthalmic complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1340",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1341",
	 description = " Other specified diabetes mellitus with diabetic mononeuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1342",
	 description = " Other specified diabetes mellitus with diabetic polyneuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1343",
	 description = " Other specified diabetes mellitus with diabetic autonomic (poly)neuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1344",
	 description = " Other specified diabetes mellitus with diabetic amyotrophy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1349",
	 description = " Other specified diabetes mellitus with other diabetic neurological complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1351",
	 description = " Other specified diabetes mellitus with diabetic peripheral angiopathy without gangrene",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1352",
	 description = " Other specified diabetes mellitus with diabetic peripheral angiopathy with gangrene",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1359",
	 description = " Other specified diabetes mellitus with other circulatory complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13610",
	 description = " Other specified diabetes mellitus with diabetic neuropathic arthropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13618",
	 description = " Other specified diabetes mellitus with other diabetic arthropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13620",
	 description = " Other specified diabetes mellitus with diabetic dermatitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13621",
	 description = " Other specified diabetes mellitus with foot ulcer",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13622",
	 description = " Other specified diabetes mellitus with other skin ulcer",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13628",
	 description = " Other specified diabetes mellitus with other skin complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13630",
	 description = " Other specified diabetes mellitus with periodontal disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13638",
	 description = " Other specified diabetes mellitus with other oral complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13640",
	 description = " Other specified diabetes mellitus with hypoglycemia without coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E13641",
	 description = " Other specified diabetes mellitus with hypoglycemia with coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1365",
	 description = " Other specified diabetes mellitus with hyperglycemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E1369",
	 description = " Other specified diabetes mellitus with other specified complication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E138",
	 description = " Other specified diabetes mellitus with unspecified complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E139",
	 description = " Other specified diabetes mellitus without complications",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E15",
	 description = " Nondiabetic hypoglycemic coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E160",
	 description = " Drug-induced hypoglycemia without coma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E161",
	 description = " Other hypoglycemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E162",
	 description = "Hypoglycemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E163",
	 description = " Increased secretion of glucagon",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E164",
	 description = " Increased secretion of gastrin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E168",
	 description = " Other specified disorders of pancreatic internal secretion",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E169",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E200",
	 description = " Idiopathic hypoparathyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E201",
	 description = " Pseudohypoparathyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E208",
	 description = " Other hypoparathyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E209",
	 description = "Hypoparathyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E210",
	 description = " Primary hyperparathyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E211",
	 description = "Secondary",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "E212",
	 description = " Other hyperparathyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E213",
	 description = "Hyperparathyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E214",
	 description = " Other specified disorders of parathyroid gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E215",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E220",
	 description = " Acromegaly and pituitary gigantism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E221",
	 description = " Hyperprolactinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E222",
	 description = " Syndrome of inappropriate secretion of antidiuretic hormone",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E228",
	 description = " Other hyperfunction of pituitary gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E229",
	 description = "Hyperfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E230",
	 description = " Hypopituitarism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E231",
	 description = " Drug-induced hypopituitarism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E232",
	 description = " Diabetes insipidus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E233",
	 description = "Hypothalamic",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "E236",
	 description = " Other disorders of pituitary gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E237",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E240",
	 description = " Pituitary-dependent Cushing's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E241",
	 description = " Nelson's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E242",
	 description = " Drug-induced Cushing's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E243",
	 description = " Ectopic ACTH syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E244",
	 description = " Alcohol-induced pseudo-Cushing's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E248",
	 description = " Other Cushing's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E249",
	 description = "Cushing's",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E250",
	 description = " Congenital adrenogenital disorders associated with enzyme deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E258",
	 description = " Other adrenogenital disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E259",
	 description = "Adrenogenital",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E2601",
	 description = " Conn's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E2602",
	 description = " Glucocorticoid-remediable aldosteronism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E2609",
	 description = " Other primary hyperaldosteronism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E261",
	 description = " Secondary hyperaldosteronism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E2681",
	 description = " Bartter's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E2689",
	 description = " Other hyperaldosteronism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E269",
	 description = "Hyperaldosteronism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E270",
	 description = " Other adrenocortical overactivity",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E271",
	 description = " Primary adrenocortical insufficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E272",
	 description = " Addisonian crisis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E273",
	 description = " Drug-induced adrenocortical insufficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E2740",
	 description = " Unspecified adrenocortical insufficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E2749",
	 description = " Other adrenocortical insufficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E275",
	 description = " Adrenomedullary hyperfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E278",
	 description = " Other specified disorders of adrenal gland",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E279",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E280",
	 description = " Estrogen excess",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E281",
	 description = " Androgen excess",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E282",
	 description = " Polycystic ovarian syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E28310",
	 description = " Symptomatic premature menopause",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E28319",
	 description = " Asymptomatic premature menopause",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E2839",
	 description = " Other primary ovarian failure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E288",
	 description = " Other ovarian dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E289",
	 description = "Ovarian",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E290",
	 description = " Testicular hyperfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E291",
	 description = " Testicular hypofunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E298",
	 description = " Other testicular dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E299",
	 description = "Testicular",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E300",
	 description = " Delayed puberty",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E301",
	 description = " Precocious puberty",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E308",
	 description = " Other disorders of puberty",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E309",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E310",
	 description = " Autoimmune polyglandular failure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E311",
	 description = " Polyglandular hyperfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E3120",
	 description = "Multiple",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E3121",
	 description = " Multiple endocrine neoplasia [MEN] type I",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E3122",
	 description = " Multiple endocrine neoplasia [MEN] type IIA",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E3123",
	 description = " Multiple endocrine neoplasia [MEN] type IIB",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E318",
	 description = " Other polyglandular dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E319",
	 description = "Polyglandular",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E320",
	 description = " Persistent hyperplasia of thymus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E321",
	 description = " Abscess of thymus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E328",
	 description = " Other diseases of thymus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E329",
	 description = "Disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E340",
	 description = " Carcinoid syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E341",
	 description = " Other hypersecretion of intestinal hormones",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E342",
	 description = "Ectopic",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "E343",
	 description = " Short stature due to endocrine disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E344",
	 description = " Constitutional tall stature",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E345",
	 description = " Androgen insensitivity syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E348",
	 description = " Other specified endocrine disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E349",
	 description = "Endocrine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E35",
	 description = " Disorders of endocrine glands in diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E3601",
	 description = " Intraoperative hemorrhage and hematoma of an endocrine system organ or structure complicating an endocrine system procedure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E3602",
	 description = " Intraoperative hemorrhage and hematoma of an endocrine system organ or structure complicating other procedure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E3611",
	 description = " Accidental puncture and laceration of an endocrine system organ or structure during an endocrine system procedure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E3612",
	 description = " Accidental puncture and laceration of an endocrine system organ or structure during other procedure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E368",
	 description = " Other intraoperative complications of endocrine system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E40",
	 description = " Kwashiorkor",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E41",
	 description = " Nutritional marasmus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E42",
	 description = " Marasmic kwashiorkor",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E43",
	 description = " Unspecified severe protein- calorie malnutrition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E440",
	 description = " Moderate protein-calorie malnutrition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E441",
	 description = " Mild protein-calorie malnutrition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E45",
	 description = " Retarded development following protein-calorie malnutrition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E46",
	 description = " Unspecified protein- calorie malnutrition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E500",
	 description = " Vitamin A deficiency with conjunctival xerosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E501",
	 description = " Vitamin A deficiency with Bitot's spot and conjunctival xerosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E502",
	 description = " Vitamin A deficiency with corneal xerosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E503",
	 description = " Vitamin A deficiency with corneal ulceration and xerosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E504",
	 description = " Vitamin A deficiency with keratomalacia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E505",
	 description = " Vitamin A deficiency with night blindness",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E506",
	 description = " Vitamin A deficiency with xerophthalmic scars of cornea",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E507",
	 description = " Other ocular manifestations of vitamin A deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E508",
	 description = " Other manifestations of vitamin A deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E509",
	 description = "Vitamin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E5111",
	 description = " Dry beriberi",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E5112",
	 description = " Wet beriberi",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E512",
	 description = " Wernicke's encephalopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E518",
	 description = " Other manifestations of thiamine deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E519",
	 description = "Thiamine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E52",
	 description = " Niacin deficiency [pellagra]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E530",
	 description = " Riboflavin deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E531",
	 description = " Pyridoxine deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E538",
	 description = " Deficiency of other specified B group vitamins",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E539",
	 description = "Vitamin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E54",
	 description = " Ascorbic acid deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E550",
	 description = "Rickets",
	 additional = "active"
},
new ICD10
{
	 code = "E559",
	 description = "Vitamin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E560",
	 description = " Deficiency of vitamin E",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E561",
	 description = " Deficiency of vitamin K",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E568",
	 description = " Deficiency of other vitamins",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E569",
	 description = "Vitamin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E58",
	 description = " Dietary calcium deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E59",
	 description = " Dietary selenium deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E60",
	 description = " Dietary zinc deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E610",
	 description = " Copper deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E611",
	 description = " Iron deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E612",
	 description = " Magnesium deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E613",
	 description = " Manganese deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E614",
	 description = " Chromium deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E615",
	 description = " Molybdenum deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E616",
	 description = " Vanadium deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E617",
	 description = " Deficiency of multiple nutrient elements",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E618",
	 description = " Deficiency of other specified nutrient elements",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E619",
	 description = "Deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E630",
	 description = " Essential fatty acid [EFA] deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E631",
	 description = " Imbalance of constituents of food intake",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E638",
	 description = " Other specified nutritional deficiencies",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E639",
	 description = "Nutritional",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E640",
	 description = " Sequelae of protein-calorie malnutrition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E641",
	 description = " Sequelae of vitamin A deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E642",
	 description = " Sequelae of vitamin C deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E643",
	 description = " Sequelae of rickets",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E648",
	 description = " Sequelae of other nutritional deficiencies",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E649",
	 description = " Sequelae of unspecified nutritional deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E65",
	 description = " Localized adiposity",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E6601",
	 description = " Morbid (severe) obesity due to excess calories",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E6609",
	 description = " Other obesity due to excess calories",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E661",
	 description = " Drug-induced obesity",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E662",
	 description = " Morbid (severe) obesity with alveolar hypoventilation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E663",
	 description = " Overweight",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E668",
	 description = " Other obesity",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E669",
	 description = "Obesity",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E670",
	 description = " Hypervitaminosis A",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E671",
	 description = " Hypercarotinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E672",
	 description = " Megavitamin-B6 syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E673",
	 description = " Hypervitaminosis D",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E678",
	 description = " Other specified hyperalimentation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E68",
	 description = " Sequelae of hyperalimentation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E700",
	 description = " Classical phenylketonuria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E701",
	 description = " Other hyperphenylalaninemias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7020",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7021",
	 description = " Tyrosinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7029",
	 description = " Other disorders of tyrosine metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7030",
	 description = "Albinism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E70310",
	 description = " X-linked ocular albinism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E70311",
	 description = " Autosomal recessive ocular albinism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E70318",
	 description = " Other ocular albinism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E70319",
	 description = "Ocular",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E70320",
	 description = " Tyrosinase negative oculocutaneous albinism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E70321",
	 description = " Tyrosinase positive oculocutaneous albinism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E70328",
	 description = " Other oculocutaneous albinism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E70329",
	 description = "Oculocutaneous",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E70330",
	 description = " Chediak-Higashi syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E70331",
	 description = " Hermansky-Pudlak syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E70338",
	 description = " Other albinism with hematologic abnormality",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E70339",
	 description = "Albinism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7039",
	 description = " Other specified albinism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7040",
	 description = "Disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7041",
	 description = " Histidinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7049",
	 description = " Other disorders of histidine metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E705",
	 description = " Disorders of tryptophan metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E708",
	 description = " Other disorders of aromatic amino-acid metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E709",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E710",
	 description = " Maple-syrup-urine disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71110",
	 description = " Isovaleric acidemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71111",
	 description = " 3-methylglutaconic aciduria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71118",
	 description = " Other branched-chain organic acidurias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71120",
	 description = " Methylmalonic acidemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71121",
	 description = " Propionic acidemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71128",
	 description = " Other disorders of propionate metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7119",
	 description = " Other disorders of branched-chain amino-acid metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E712",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7130",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71310",
	 description = " Long chain/very long chain acyl CoA dehydrogenase deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71311",
	 description = " Medium chain acyl CoA dehydrogenase deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71312",
	 description = " Short chain acyl CoA dehydrogenase deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71313",
	 description = " Glutaric aciduria type II",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71314",
	 description = " Muscle carnitine palmitoyltransferase deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71318",
	 description = " Other disorders of fatty-acid oxidation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7132",
	 description = " Disorders of ketone metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7139",
	 description = " Other disorders of fatty-acid metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7140",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7141",
	 description = " Primary carnitine deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7142",
	 description = " Carnitine deficiency due to inborn errors of metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7143",
	 description = " Iatrogenic carnitine deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71440",
	 description = " Ruvalcaba-Myhre-Smith syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71448",
	 description = " Other secondary carnitine deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7150",
	 description = "Peroxisomal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71510",
	 description = " Zellweger syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71511",
	 description = " Neonatal adrenoleukodystrophy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71518",
	 description = " Other disorders of peroxisome biogenesis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71520",
	 description = " Childhood cerebral X-linked adrenoleukodystrophy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71521",
	 description = " Adolescent X-linked adrenoleukodystrophy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71522",
	 description = " Adrenomyeloneuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71528",
	 description = " Other X-linked adrenoleukodystrophy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71529",
	 description = "X-linked",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7153",
	 description = " Other group 2 peroxisomal disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71540",
	 description = " Rhizomelic chondrodysplasia punctata",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71541",
	 description = " Zellweger-like syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71542",
	 description = " Other group 3 peroxisomal disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E71548",
	 description = " Other peroxisomal disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7200",
	 description = "Disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7201",
	 description = " Cystinuria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7202",
	 description = " Hartnup's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7203",
	 description = " Lowe's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7204",
	 description = " Cystinosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7209",
	 description = " Other disorders of amino-acid transport",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7210",
	 description = "Disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7211",
	 description = " Homocystinuria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7212",
	 description = " Methylenetetrahydrofolate reductase deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7219",
	 description = " Other disorders of sulfur-bearing amino-acid metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7220",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7221",
	 description = " Argininemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7222",
	 description = " Arginosuccinic aciduria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7223",
	 description = " Citrullinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7229",
	 description = " Other disorders of urea cycle metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E723",
	 description = " Disorders of lysine and hydroxylysine metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E724",
	 description = " Disorders of ornithine metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7250",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7251",
	 description = " Non-ketotic hyperglycinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7252",
	 description = " Trimethylaminuria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7253",
	 description = " Hyperoxaluria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7259",
	 description = " Other disorders of glycine metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E728",
	 description = " Other specified disorders of amino-acid metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E729",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E730",
	 description = " Congenital lactase deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E731",
	 description = " Secondary lactase deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E738",
	 description = " Other lactose intolerance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E739",
	 description = "Lactose",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7400",
	 description = "Glycogen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7401",
	 description = " Von Gierke's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7402",
	 description = " Pompe's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7403",
	 description = " Cori's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7404",
	 description = " McArdle's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7409",
	 description = " Other glycogen storage disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7410",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7411",
	 description = " Essential fructosuria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7412",
	 description = " Hereditary fructose intolerance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7419",
	 description = " Other disorders of fructose metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7420",
	 description = "Disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7421",
	 description = " Galactosemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7429",
	 description = " Other disorders of galactose metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7431",
	 description = " Sucrase-isomaltase deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7439",
	 description = " Other disorders of intestinal carbohydrate absorption",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E744",
	 description = " Disorders of pyruvate metabolism and gluconeogenesis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E748",
	 description = " Other specified disorders of carbohydrate metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E749",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7500",
	 description = "GM2",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7501",
	 description = " Sandhoff disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7502",
	 description = " Tay-Sachs disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7509",
	 description = " Other GM2 gangliosidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7510",
	 description = " Unspecified gangliosidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7511",
	 description = " Mucolipidosis IV",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7519",
	 description = " Other gangliosidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7521",
	 description = " Fabry (-Anderson) disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7522",
	 description = " Gaucher disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7523",
	 description = " Krabbe disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E75240",
	 description = " Niemann-Pick disease type A",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E75241",
	 description = " Niemann-Pick disease type B",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E75242",
	 description = " Niemann-Pick disease type C",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E75243",
	 description = " Niemann-Pick disease type D",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E75248",
	 description = " Other Niemann-Pick disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E75249",
	 description = "Niemann-Pick",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7525",
	 description = " Metachromatic leukodystrophy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7529",
	 description = " Other sphingolipidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E753",
	 description = "Sphingolipidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E754",
	 description = " Neuronal ceroid lipofuscinosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E755",
	 description = " Other lipid storage disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E756",
	 description = "Lipid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7601",
	 description = " Hurler's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7602",
	 description = " Hurler-Scheie syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7603",
	 description = " Scheie's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E761",
	 description = "Mucopolysaccharidosis",
	 additional = "type II"
},
new ICD10
{
	 code = "E76210",
	 description = " Morquio A mucopolysaccharidoses",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E76211",
	 description = " Morquio B mucopolysaccharidoses",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E76219",
	 description = "Morquio",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7622",
	 description = " Sanfilippo mucopolysaccharidoses",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7629",
	 description = " Other mucopolysaccharidoses",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E763",
	 description = "Mucopolysaccharidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E768",
	 description = " Other disorders of glucosaminoglycan metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E769",
	 description = "Glucosaminoglycan",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E770",
	 description = " Defects in post-translational modification of lysosomal enzymes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E771",
	 description = " Defects in glycoprotein degradation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E778",
	 description = " Other disorders of glycoprotein metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E779",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E780",
	 description = " Pure hypercholesterolemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E781",
	 description = " Pure hyperglyceridemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E782",
	 description = " Mixed hyperlipidemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E783",
	 description = " Hyperchylomicronemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E784",
	 description = " Other hyperlipidemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E785",
	 description = "Hyperlipidemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E786",
	 description = " Lipoprotein deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7870",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7871",
	 description = " Barth syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7872",
	 description = " Smith-Lemli-Opitz syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7879",
	 description = " Other disorders of bile acid and cholesterol metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7881",
	 description = " Lipoid dermatoarthritis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E7889",
	 description = " Other lipoprotein metabolism disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E789",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E790",
	 description = " Hyperuricemia without signs of inflammatory arthritis and tophaceous disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E791",
	 description = " Lesch-Nyhan syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E792",
	 description = " Myoadenylate deaminase deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E798",
	 description = " Other disorders of purine and pyrimidine metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E799",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E800",
	 description = " Hereditary erythropoietic porphyria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E801",
	 description = " Porphyria cutanea tarda",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8020",
	 description = " Unspecified porphyria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8021",
	 description = " Acute intermittent (hepatic) porphyria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8029",
	 description = " Other porphyria",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E803",
	 description = " Defects of catalase and peroxidase",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E804",
	 description = " Gilbert's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E805",
	 description = " Crigler-Najjar syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E806",
	 description = " Other disorders of bilirubin metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E807",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8300",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8301",
	 description = " Wilson's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8309",
	 description = " Other disorders of copper metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8310",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8311",
	 description = " Hemochromatosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8319",
	 description = " Other disorders of iron metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E832",
	 description = " Disorders of zinc metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8330",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8331",
	 description = " Familial hypophosphatemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8332",
	 description = " Hereditary vitamin D-dependent rickets (type 1) (type 2)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8339",
	 description = " Other disorders of phosphorus metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8340",
	 description = "Disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8341",
	 description = " Hypermagnesemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8342",
	 description = " Hypomagnesemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8349",
	 description = " Other disorders of magnesium metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8350",
	 description = " Unspecified disorder of calcium metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8351",
	 description = " Hypocalcemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8352",
	 description = " Hypercalcemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8359",
	 description = " Other disorders of calcium metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E838",
	 description = " Other disorders of mineral metabolism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E839",
	 description = "Disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E840",
	 description = " Cystic fibrosis with pulmonary manifestations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8411",
	 description = " Meconium ileus in cystic fibrosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8419",
	 description = " Cystic fibrosis with other intestinal manifestations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E848",
	 description = " Cystic fibrosis with other manifestations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E849",
	 description = "Cystic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E850",
	 description = " Non-neuropathic heredofamilial amyloidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E851",
	 description = " Neuropathic heredofamilial amyloidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E852",
	 description = "Heredofamilial",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E853",
	 description = " Secondary systemic amyloidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E854",
	 description = " Organ-limited amyloidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E858",
	 description = " Other amyloidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E859",
	 description = "Amyloidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E860",
	 description = " Dehydration",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E861",
	 description = " Hypovolemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E869",
	 description = "Volume",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E870",
	 description = " Hyperosmolality and hypernatremia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E871",
	 description = " Hypo-osmolality and hyponatremia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E872",
	 description = " Acidosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E873",
	 description = " Alkalosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E874",
	 description = " Mixed disorder of acid-base balance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E875",
	 description = " Hyperkalemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E876",
	 description = " Hypokalemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E877",
	 description = " Fluid overload",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E878",
	 description = "Other",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "E8801",
	 description = " Alpha-1-antitrypsin deficiency",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8809",
	 description = "Other",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "E881",
	 description = "Lipodystrophy",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "E882",
	 description = "Lipomatosis",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "E8830",
	 description = "Mitochondrial",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8831",
	 description = " MELAS syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8832",
	 description = " MERRF syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8839",
	 description = " Other mitochondrial metabolism disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8881",
	 description = " Metabolic syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8889",
	 description = " Other specified metabolic disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E889",
	 description = "Metabolic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E890",
	 description = " Postprocedural hypothyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E891",
	 description = " Postprocedural hypoinsulinemia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E892",
	 description = " Postprocedural hypoparathyroidism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E893",
	 description = " Postprocedural hypopituitarism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8940",
	 description = " Asymptomatic postprocedural ovarian failure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8941",
	 description = " Symptomatic postprocedural ovarian failure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E895",
	 description = " Postprocedural testicular hypofunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E896",
	 description = " Postprocedural adrenocortical (-medullary) hypofunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E89810",
	 description = " Postprocedural hemorrhage and hematoma of an endocrine system organ or structure following an endocrine system procedure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E89811",
	 description = " Postprocedural hemorrhage and hematoma of an endocrine system organ or structure following other procedure",
	 additional = "unspecified"
},
new ICD10
{
	 code = "E8989",
	 description = " Other postprocedural endocrine and metabolic complications and disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F0150",
	 description = " Vascular dementia without behavioral disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F0151",
	 description = " Vascular dementia with behavioral disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F0280",
	 description = "Dementia",
	 additional = "without behavioral disturbance"
},
new ICD10
{
	 code = "F0281",
	 description = "Dementia",
	 additional = "with behavioral disturbance"
},
new ICD10
{
	 code = "F03",
	 description = " Unspecified dementia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F04",
	 description = " Amnestic disorder due to known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F05",
	 description = " Delirium due to known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F060",
	 description = " Psychotic disorder with hallucinations due to known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F061",
	 description = " Catatonic disorder due to known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F062",
	 description = " Psychotic disorder with delusions due to known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F0630",
	 description = "Mood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F0631",
	 description = " Mood disorder due to known physiological condition with depressive features",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F0632",
	 description = " Mood disorder due to known physiological condition with major depressive-like episode",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F0633",
	 description = " Mood disorder due to known physiological condition with manic features",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F0634",
	 description = " Mood disorder due to known physiological condition with mixed features",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F064",
	 description = " Anxiety disorder due to known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F068",
	 description = " Other specified mental disorders due to known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F069",
	 description = " Unspecified mental disorder due to known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F070",
	 description = " Personality change due to known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F0781",
	 description = " Postconcussional syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F0789",
	 description = " Other personality and behavioral disorders due to known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F079",
	 description = " Unspecified personality and behavioral disorder due to known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F09",
	 description = " Unspecified mental disorder due to known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1010",
	 description = "Alcohol",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F10120",
	 description = "Alcohol",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F10121",
	 description = " Alcohol abuse with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10129",
	 description = "Alcohol",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1014",
	 description = " Alcohol abuse with alcohol-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10150",
	 description = " Alcohol abuse with alcohol-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10151",
	 description = " Alcohol abuse with alcohol-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10159",
	 description = "Alcohol",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10180",
	 description = " Alcohol abuse with alcohol-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10181",
	 description = " Alcohol abuse with alcohol-induced sexual dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10182",
	 description = " Alcohol abuse with alcohol-induced sleep disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10188",
	 description = " Alcohol abuse with other alcohol-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1019",
	 description = " Alcohol abuse with unspecified alcohol-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1020",
	 description = "Alcohol",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F1021",
	 description = "Alcohol",
	 additional = "in remission"
},
new ICD10
{
	 code = "F10220",
	 description = "Alcohol",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F10221",
	 description = " Alcohol dependence with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10229",
	 description = "Alcohol",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10230",
	 description = "Alcohol",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F10231",
	 description = " Alcohol dependence with withdrawal delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10232",
	 description = " Alcohol dependence with withdrawal with perceptual disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10239",
	 description = "Alcohol",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1024",
	 description = " Alcohol dependence with alcohol-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10250",
	 description = " Alcohol dependence with alcohol-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10251",
	 description = " Alcohol dependence with alcohol-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10259",
	 description = "Alcohol",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1026",
	 description = " Alcohol dependence with alcohol-induced persisting amnestic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1027",
	 description = " Alcohol dependence with alcohol-induced persisting dementia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10280",
	 description = " Alcohol dependence with alcohol-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10281",
	 description = " Alcohol dependence with alcohol-induced sexual dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10282",
	 description = " Alcohol dependence with alcohol-induced sleep disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10288",
	 description = " Alcohol dependence with other alcohol-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1029",
	 description = " Alcohol dependence with unspecified alcohol-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F10920  Alcohol use",
	 description = "unspecified with intoxication",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F10921",
	 description = "Alcohol",
	 additional = "unspecified with intoxication delirium"
},
new ICD10
{
	 code = "F10929  Alcohol use",
	 description = "unspecified with intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1094",
	 description = "Alcohol",
	 additional = "unspecified with alcohol-induced mood disorder"
},
new ICD10
{
	 code = "F10950",
	 description = "Alcohol",
	 additional = "unspecified with alcohol-induced psychotic disorder with delusions"
},
new ICD10
{
	 code = "F10951",
	 description = "Alcohol",
	 additional = "unspecified with alcohol-induced psychotic disorder with hallucinations"
},
new ICD10
{
	 code = "F10959  Alcohol use",
	 description = "unspecified with alcohol-induced psychotic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1096",
	 description = "Alcohol",
	 additional = "unspecified with alcohol-induced persisting amnestic disorder"
},
new ICD10
{
	 code = "F1097",
	 description = "Alcohol",
	 additional = "unspecified with alcohol-induced persisting dementia"
},
new ICD10
{
	 code = "F10980",
	 description = "Alcohol",
	 additional = "unspecified with alcohol-induced anxiety disorder"
},
new ICD10
{
	 code = "F10981",
	 description = "Alcohol",
	 additional = "unspecified with alcohol-induced sexual dysfunction"
},
new ICD10
{
	 code = "F10982",
	 description = "Alcohol",
	 additional = "unspecified with alcohol-induced sleep disorder"
},
new ICD10
{
	 code = "F10988",
	 description = "Alcohol",
	 additional = "unspecified with other alcohol-induced disorder"
},
new ICD10
{
	 code = "F1099",
	 description = "Alcohol",
	 additional = "unspecified with unspecified alcohol-induced disorder"
},
new ICD10
{
	 code = "F1110",
	 description = "Opioid",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F11120",
	 description = "Opioid",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F11121",
	 description = " Opioid abuse with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11122",
	 description = " Opioid abuse with intoxication with perceptual disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11129",
	 description = "Opioid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1114",
	 description = " Opioid abuse with opioid-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11150",
	 description = " Opioid abuse with opioid-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11151",
	 description = " Opioid abuse with opioid-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11159",
	 description = "Opioid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11181",
	 description = " Opioid abuse with opioid-induced sexual dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11182",
	 description = " Opioid abuse with opioid-induced sleep disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11188",
	 description = " Opioid abuse with other opioid-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1119",
	 description = " Opioid abuse with unspecified opioid-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1120",
	 description = "Opioid",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F1121",
	 description = "Opioid",
	 additional = "in remission"
},
new ICD10
{
	 code = "F11220",
	 description = "Opioid",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F11221",
	 description = " Opioid dependence with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11222",
	 description = " Opioid dependence with intoxication with perceptual disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11229",
	 description = "Opioid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1123",
	 description = " Opioid dependence with withdrawal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1124",
	 description = " Opioid dependence with opioid-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11250",
	 description = " Opioid dependence with opioid-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11251",
	 description = " Opioid dependence with opioid-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11259",
	 description = "Opioid",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11281",
	 description = " Opioid dependence with opioid-induced sexual dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11282",
	 description = " Opioid dependence with opioid-induced sleep disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11288",
	 description = " Opioid dependence with other opioid-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1129",
	 description = " Opioid dependence with unspecified opioid-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1190   Opioid use",
	 description = "unspecified",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F11920  Opioid use",
	 description = "unspecified with intoxication",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F11921",
	 description = "Opioid",
	 additional = "unspecified with intoxication delirium"
},
new ICD10
{
	 code = "F11922",
	 description = "Opioid",
	 additional = "unspecified with intoxication with perceptual disturbance"
},
new ICD10
{
	 code = "F11929  Opioid use",
	 description = "unspecified with intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1193",
	 description = "Opioid",
	 additional = "unspecified with withdrawal"
},
new ICD10
{
	 code = "F1194",
	 description = "Opioid",
	 additional = "unspecified with opioid-induced mood disorder"
},
new ICD10
{
	 code = "F11950",
	 description = "Opioid",
	 additional = "unspecified with opioid-induced psychotic disorder with delusions"
},
new ICD10
{
	 code = "F11951",
	 description = "Opioid",
	 additional = "unspecified with opioid-induced psychotic disorder with hallucinations"
},
new ICD10
{
	 code = "F11959  Opioid use",
	 description = "unspecified with opioid-induced psychotic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F11981",
	 description = "Opioid",
	 additional = "unspecified with opioid-induced sexual dysfunction"
},
new ICD10
{
	 code = "F11982",
	 description = "Opioid",
	 additional = "unspecified with opioid-induced sleep disorder"
},
new ICD10
{
	 code = "F11988",
	 description = "Opioid",
	 additional = "unspecified with other opioid-induced disorder"
},
new ICD10
{
	 code = "F1199",
	 description = "Opioid",
	 additional = "unspecified with unspecified opioid-induced disorder"
},
new ICD10
{
	 code = "F1210",
	 description = "Cannabis",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F12120",
	 description = "Cannabis",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F12121",
	 description = " Cannabis abuse with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12122",
	 description = " Cannabis abuse with intoxication with perceptual disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12129",
	 description = "Cannabis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12150",
	 description = " Cannabis abuse with psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12151",
	 description = " Cannabis abuse with psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12159",
	 description = "Cannabis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12180",
	 description = " Cannabis abuse with cannabis-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12188",
	 description = " Cannabis abuse with other cannabis-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1219",
	 description = " Cannabis abuse with unspecified cannabis-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1220",
	 description = "Cannabis",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F1221",
	 description = "Cannabis",
	 additional = "in remission"
},
new ICD10
{
	 code = "F12220",
	 description = "Cannabis",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F12221",
	 description = " Cannabis dependence with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12222",
	 description = " Cannabis dependence with intoxication with perceptual disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12229",
	 description = "Cannabis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12250",
	 description = " Cannabis dependence with psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12251",
	 description = " Cannabis dependence with psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12259",
	 description = "Cannabis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12280",
	 description = " Cannabis dependence with cannabis-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12288",
	 description = " Cannabis dependence with other cannabis-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1229",
	 description = " Cannabis dependence with unspecified cannabis-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1290   Cannabis use",
	 description = "unspecified",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F12920  Cannabis use",
	 description = "unspecified with intoxication",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F12921",
	 description = "Cannabis",
	 additional = "unspecified with intoxication delirium"
},
new ICD10
{
	 code = "F12922",
	 description = "Cannabis",
	 additional = "unspecified with intoxication with perceptual disturbance"
},
new ICD10
{
	 code = "F12929  Cannabis use",
	 description = "unspecified with intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12950",
	 description = "Cannabis",
	 additional = "unspecified with psychotic disorder with delusions"
},
new ICD10
{
	 code = "F12951",
	 description = "Cannabis",
	 additional = "unspecified with psychotic disorder with hallucinations"
},
new ICD10
{
	 code = "F12959  Cannabis use",
	 description = "unspecified with psychotic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F12980",
	 description = "Cannabis",
	 additional = "unspecified with anxiety disorder"
},
new ICD10
{
	 code = "F12988",
	 description = "Cannabis",
	 additional = "unspecified with other cannabis-induced disorder"
},
new ICD10
{
	 code = "F1299",
	 description = "Cannabis",
	 additional = "unspecified with unspecified cannabis-induced disorder"
},
new ICD10
{
	 code = "F1310   Sedative",
	 description = "hypnotic or anxiolytic abuse",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F13120  Sedative",
	 description = "hypnotic or anxiolytic abuse with intoxication",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F13121",
	 description = "Sedative",
	 additional = "hypnotic or anxiolytic abuse with intoxication delirium"
},
new ICD10
{
	 code = "F13129  Sedative",
	 description = "hypnotic or anxiolytic abuse with intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1314   Sedative",
	 description = "hypnotic or anxiolytic abuse with sedative",
	 additional = "hypnotic or anxiolytic-induced mood disorder"
},
new ICD10
{
	 code = "F13150  Sedative",
	 description = "hypnotic or anxiolytic abuse with sedative",
	 additional = "hypnotic or anxiolytic-induced psychotic disorder with delusions"
},
new ICD10
{
	 code = "F13151  Sedative",
	 description = "hypnotic or anxiolytic abuse with sedative",
	 additional = "hypnotic or anxiolytic-induced psychotic disorder with hallucinations"
},
new ICD10
{
	 code = "F13159",
	 description = " Sedative, hypnotic or anxiolytic abuse with sedative, hypnotic or anxiolytic-induced psychotic disorder, unspecified",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13180  Sedative",
	 description = "hypnotic or anxiolytic abuse with sedative",
	 additional = "hypnotic or anxiolytic-induced anxiety disorder"
},
new ICD10
{
	 code = "F13181  Sedative",
	 description = "hypnotic or anxiolytic abuse with sedative",
	 additional = "hypnotic or anxiolytic-induced sexual dysfunction"
},
new ICD10
{
	 code = "F13182  Sedative",
	 description = "hypnotic or anxiolytic abuse with sedative",
	 additional = "hypnotic or anxiolytic-induced sleep disorder"
},
new ICD10
{
	 code = "F13188  Sedative",
	 description = "hypnotic or anxiolytic abuse with other sedative",
	 additional = "hypnotic or anxiolytic-induced disorder"
},
new ICD10
{
	 code = "F1319   Sedative",
	 description = "hypnotic or anxiolytic abuse with unspecified sedative",
	 additional = "hypnotic or anxiolytic-induced disorder"
},
new ICD10
{
	 code = "F1320   Sedative",
	 description = "hypnotic or anxiolytic dependence",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F1321   Sedative",
	 description = "hypnotic or anxiolytic dependence",
	 additional = "in remission"
},
new ICD10
{
	 code = "F13220  Sedative",
	 description = "hypnotic or anxiolytic dependence with intoxication",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F13221",
	 description = "Sedative",
	 additional = "hypnotic or anxiolytic dependence with intoxication delirium"
},
new ICD10
{
	 code = "F13229  Sedative",
	 description = "hypnotic or anxiolytic dependence with intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13230  Sedative",
	 description = "hypnotic or anxiolytic dependence with withdrawal",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F13231",
	 description = "Sedative",
	 additional = "hypnotic or anxiolytic dependence with withdrawal delirium"
},
new ICD10
{
	 code = "F13232",
	 description = "Sedative",
	 additional = "hypnotic or anxiolytic dependence with withdrawal with perceptual disturbance"
},
new ICD10
{
	 code = "F13239  Sedative",
	 description = "hypnotic or anxiolytic dependence with withdrawal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1324   Sedative",
	 description = "hypnotic or anxiolytic dependence with sedative",
	 additional = "hypnotic or anxiolytic-induced mood disorder"
},
new ICD10
{
	 code = "F13250  Sedative",
	 description = "hypnotic or anxiolytic dependence with sedative",
	 additional = "hypnotic or anxiolytic-induced psychotic disorder with delusions"
},
new ICD10
{
	 code = "F13251  Sedative",
	 description = "hypnotic or anxiolytic dependence with sedative",
	 additional = "hypnotic or anxiolytic-induced psychotic disorder with hallucinations"
},
new ICD10
{
	 code = "F13259",
	 description = " Sedative, hypnotic or anxiolytic dependence with sedative, hypnotic or anxiolytic-induced psychotic disorder, unspecified",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1326   Sedative",
	 description = "hypnotic or anxiolytic dependence with sedative",
	 additional = "hypnotic or anxiolytic-induced persisting amnestic disorder"
},
new ICD10
{
	 code = "F1327   Sedative",
	 description = "hypnotic or anxiolytic dependence with sedative",
	 additional = "hypnotic or anxiolytic-induced persisting dementia"
},
new ICD10
{
	 code = "F13280  Sedative",
	 description = "hypnotic or anxiolytic dependence with sedative",
	 additional = "hypnotic or anxiolytic-induced anxiety disorder"
},
new ICD10
{
	 code = "F13281  Sedative",
	 description = "hypnotic or anxiolytic dependence with sedative",
	 additional = "hypnotic or anxiolytic-induced sexual dysfunction"
},
new ICD10
{
	 code = "F13282  Sedative",
	 description = "hypnotic or anxiolytic dependence with sedative",
	 additional = "hypnotic or anxiolytic-induced sleep disorder"
},
new ICD10
{
	 code = "F13288  Sedative",
	 description = "hypnotic or anxiolytic dependence with other sedative",
	 additional = "hypnotic or anxiolytic-induced disorder"
},
new ICD10
{
	 code = "F1329   Sedative",
	 description = "hypnotic or anxiolytic dependence with unspecified sedative",
	 additional = "hypnotic or anxiolytic-induced disorder"
},
new ICD10
{
	 code = "F1390",
	 description = " Sedative, hypnotic, or anxiolytic use, unspecified, uncomplicated",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13920",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with intoxication, uncomplicated",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13921  Sedative",
	 description = "hypnotic or anxiolytic use",
	 additional = "unspecified with intoxication delirium"
},
new ICD10
{
	 code = "F13929",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with intoxication, unspecified",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13930",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with withdrawal, uncomplicated",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13931  Sedative",
	 description = "hypnotic or anxiolytic use",
	 additional = "unspecified with withdrawal delirium"
},
new ICD10
{
	 code = "F13932  Sedative",
	 description = "hypnotic or anxiolytic use",
	 additional = "unspecified with withdrawal with perceptual disturbances"
},
new ICD10
{
	 code = "F13939",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with withdrawal, unspecified",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1394",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with sedative, hypnotic or anxiolytic-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13950",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with sedative, hypnotic or anxiolytic-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13951",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with sedative, hypnotic or anxiolytic-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13959",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with sedative, hypnotic or anxiolytic-induced psychotic disorder, unspecified",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1396",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with sedative, hypnotic or anxiolytic-induced persisting amnestic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1397",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with sedative, hypnotic or anxiolytic-induced persisting dementia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13980",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with sedative, hypnotic or anxiolytic-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13981",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with sedative, hypnotic or anxiolytic-induced sexual dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13982",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with sedative, hypnotic or anxiolytic-induced sleep disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F13988",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with other sedative, hypnotic or anxiolytic-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1399",
	 description = " Sedative, hypnotic or anxiolytic use, unspecified with unspecified sedative, hypnotic or anxiolytic-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1410",
	 description = "Cocaine",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F14120",
	 description = "Cocaine",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F14121",
	 description = " Cocaine abuse with intoxication with delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14122",
	 description = " Cocaine abuse with intoxication with perceptual disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14129",
	 description = "Cocaine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1414",
	 description = " Cocaine abuse with cocaine-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14150",
	 description = " Cocaine abuse with cocaine-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14151",
	 description = " Cocaine abuse with cocaine-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14159",
	 description = "Cocaine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14180",
	 description = " Cocaine abuse with cocaine-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14181",
	 description = " Cocaine abuse with cocaine-induced sexual dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14182",
	 description = " Cocaine abuse with cocaine-induced sleep disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14188",
	 description = " Cocaine abuse with other cocaine-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1419",
	 description = " Cocaine abuse with unspecified cocaine-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1420",
	 description = "Cocaine",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F1421",
	 description = "Cocaine",
	 additional = "in remission"
},
new ICD10
{
	 code = "F14220",
	 description = "Cocaine",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F14221",
	 description = " Cocaine dependence with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14222",
	 description = " Cocaine dependence with intoxication with perceptual disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14229",
	 description = "Cocaine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1423",
	 description = " Cocaine dependence with withdrawal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1424",
	 description = " Cocaine dependence with cocaine-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14250",
	 description = " Cocaine dependence with cocaine-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14251",
	 description = " Cocaine dependence with cocaine-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14259",
	 description = "Cocaine",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14280",
	 description = " Cocaine dependence with cocaine-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14281",
	 description = " Cocaine dependence with cocaine-induced sexual dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14282",
	 description = " Cocaine dependence with cocaine-induced sleep disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14288",
	 description = " Cocaine dependence with other cocaine-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1429",
	 description = " Cocaine dependence with unspecified cocaine-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1490   Cocaine use",
	 description = "unspecified",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F14920  Cocaine use",
	 description = "unspecified with intoxication",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F14921",
	 description = "Cocaine",
	 additional = "unspecified with intoxication delirium"
},
new ICD10
{
	 code = "F14922",
	 description = "Cocaine",
	 additional = "unspecified with intoxication with perceptual disturbance"
},
new ICD10
{
	 code = "F14929  Cocaine use",
	 description = "unspecified with intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1494",
	 description = "Cocaine",
	 additional = "unspecified with cocaine-induced mood disorder"
},
new ICD10
{
	 code = "F14950",
	 description = "Cocaine",
	 additional = "unspecified with cocaine-induced psychotic disorder with delusions"
},
new ICD10
{
	 code = "F14951",
	 description = "Cocaine",
	 additional = "unspecified with cocaine-induced psychotic disorder with hallucinations"
},
new ICD10
{
	 code = "F14959  Cocaine use",
	 description = "unspecified with cocaine-induced psychotic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F14980",
	 description = "Cocaine",
	 additional = "unspecified with cocaine-induced anxiety disorder"
},
new ICD10
{
	 code = "F14981",
	 description = "Cocaine",
	 additional = "unspecified with cocaine-induced sexual dysfunction"
},
new ICD10
{
	 code = "F14982",
	 description = "Cocaine",
	 additional = "unspecified with cocaine-induced sleep disorder"
},
new ICD10
{
	 code = "F14988",
	 description = "Cocaine",
	 additional = "unspecified with other cocaine-induced disorder"
},
new ICD10
{
	 code = "F1499",
	 description = "Cocaine",
	 additional = "unspecified with unspecified cocaine-induced disorder"
},
new ICD10
{
	 code = "F1510",
	 description = "Other",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F15120",
	 description = "Other",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F15121",
	 description = " Other stimulant abuse with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15122",
	 description = " Other stimulant abuse with intoxication with perceptual disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15129",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1514",
	 description = " Other stimulant abuse with stimulant-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15150",
	 description = " Other stimulant abuse with stimulant-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15151",
	 description = " Other stimulant abuse with stimulant-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15159",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15180",
	 description = " Other stimulant abuse with stimulant-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15181",
	 description = " Other stimulant abuse with stimulant-induced sexual dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15182",
	 description = " Other stimulant abuse with stimulant-induced sleep disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15188",
	 description = " Other stimulant abuse with other stimulant-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1519",
	 description = " Other stimulant abuse with unspecified stimulant-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1520",
	 description = "Other",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F1521",
	 description = "Other",
	 additional = "in remission"
},
new ICD10
{
	 code = "F15220",
	 description = "Other",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F15221",
	 description = " Other stimulant dependence with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15222",
	 description = " Other stimulant dependence with intoxication with perceptual disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15229",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1523",
	 description = " Other stimulant dependence with withdrawal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1524",
	 description = " Other stimulant dependence with stimulant-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15250",
	 description = " Other stimulant dependence with stimulant-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15251",
	 description = " Other stimulant dependence with stimulant-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15259",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15280",
	 description = " Other stimulant dependence with stimulant-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15281",
	 description = " Other stimulant dependence with stimulant-induced sexual dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15282",
	 description = " Other stimulant dependence with stimulant-induced sleep disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15288",
	 description = " Other stimulant dependence with other stimulant-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1529",
	 description = " Other stimulant dependence with unspecified stimulant-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1590   Other stimulant use",
	 description = "unspecified",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F15920  Other stimulant use",
	 description = "unspecified with intoxication",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F15921",
	 description = "Other",
	 additional = "unspecified with intoxication delirium"
},
new ICD10
{
	 code = "F15922",
	 description = "Other",
	 additional = "unspecified with intoxication with perceptual disturbance"
},
new ICD10
{
	 code = "F15929  Other stimulant use",
	 description = "unspecified with intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1593",
	 description = "Other",
	 additional = "unspecified with withdrawal"
},
new ICD10
{
	 code = "F1594",
	 description = "Other",
	 additional = "unspecified with stimulant-induced mood disorder"
},
new ICD10
{
	 code = "F15950",
	 description = "Other",
	 additional = "unspecified with stimulant-induced psychotic disorder with delusions"
},
new ICD10
{
	 code = "F15951",
	 description = "Other",
	 additional = "unspecified with stimulant-induced psychotic disorder with hallucinations"
},
new ICD10
{
	 code = "F15959  Other stimulant use",
	 description = "unspecified with stimulant-induced psychotic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F15980",
	 description = "Other",
	 additional = "unspecified with stimulant-induced anxiety disorder"
},
new ICD10
{
	 code = "F15981",
	 description = "Other",
	 additional = "unspecified with stimulant-induced sexual dysfunction"
},
new ICD10
{
	 code = "F15982",
	 description = "Other",
	 additional = "unspecified with stimulant-induced sleep disorder"
},
new ICD10
{
	 code = "F15988",
	 description = "Other",
	 additional = "unspecified with other stimulant-induced disorder"
},
new ICD10
{
	 code = "F1599",
	 description = "Other",
	 additional = "unspecified with unspecified stimulant-induced disorder"
},
new ICD10
{
	 code = "F1610",
	 description = "Hallucinogen",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F16120",
	 description = "Hallucinogen",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F16121",
	 description = " Hallucinogen abuse with intoxication with delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16122",
	 description = " Hallucinogen abuse with intoxication with perceptual disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16129",
	 description = "Hallucinogen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1614",
	 description = " Hallucinogen abuse with hallucinogen-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16150",
	 description = " Hallucinogen abuse with hallucinogen-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16151",
	 description = " Hallucinogen abuse with hallucinogen-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16159",
	 description = "Hallucinogen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16180",
	 description = " Hallucinogen abuse with hallucinogen-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16183",
	 description = " Hallucinogen abuse with hallucinogen persisting perception disorder (flashbacks)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16188",
	 description = " Hallucinogen abuse with other hallucinogen-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1619",
	 description = " Hallucinogen abuse with unspecified hallucinogen-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1620",
	 description = "Hallucinogen",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F1621",
	 description = "Hallucinogen",
	 additional = "in remission"
},
new ICD10
{
	 code = "F16220",
	 description = "Hallucinogen",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F16221",
	 description = " Hallucinogen dependence with intoxication with delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16229",
	 description = "Hallucinogen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1624",
	 description = " Hallucinogen dependence with hallucinogen-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16250",
	 description = " Hallucinogen dependence with hallucinogen-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16251",
	 description = " Hallucinogen dependence with hallucinogen-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16259",
	 description = "Hallucinogen",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16280",
	 description = " Hallucinogen dependence with hallucinogen-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16283",
	 description = " Hallucinogen dependence with hallucinogen persisting perception disorder (flashbacks)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16288",
	 description = " Hallucinogen dependence with other hallucinogen-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1629",
	 description = " Hallucinogen dependence with unspecified hallucinogen-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1690   Hallucinogen use",
	 description = "unspecified",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F16920  Hallucinogen use",
	 description = "unspecified with intoxication",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F16921",
	 description = "Hallucinogen",
	 additional = "unspecified with intoxication with delirium"
},
new ICD10
{
	 code = "F16929  Hallucinogen use",
	 description = "unspecified with intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1694",
	 description = "Hallucinogen",
	 additional = "unspecified with hallucinogen-induced mood disorder"
},
new ICD10
{
	 code = "F16950",
	 description = "Hallucinogen",
	 additional = "unspecified with hallucinogen-induced psychotic disorder with delusions"
},
new ICD10
{
	 code = "F16951",
	 description = "Hallucinogen",
	 additional = "unspecified with hallucinogen-induced psychotic disorder with hallucinations"
},
new ICD10
{
	 code = "F16959  Hallucinogen use",
	 description = "unspecified with hallucinogen-induced psychotic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F16980",
	 description = "Hallucinogen",
	 additional = "unspecified with hallucinogen-induced anxiety disorder"
},
new ICD10
{
	 code = "F16983",
	 description = "Hallucinogen",
	 additional = "unspecified with hallucinogen persisting perception disorder (flashbacks)"
},
new ICD10
{
	 code = "F16988",
	 description = "Hallucinogen",
	 additional = "unspecified with other hallucinogen-induced disorder"
},
new ICD10
{
	 code = "F1699",
	 description = "Hallucinogen",
	 additional = "unspecified with unspecified hallucinogen-induced disorder"
},
new ICD10
{
	 code = "F17200  Nicotine dependence",
	 description = "unspecified",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F17201  Nicotine dependence",
	 description = "unspecified",
	 additional = "in remission"
},
new ICD10
{
	 code = "F17203",
	 description = "Nicotine",
	 additional = "with withdrawal"
},
new ICD10
{
	 code = "F17208  Nicotine dependence",
	 description = "unspecified",
	 additional = "with other nicotine-induced disorders"
},
new ICD10
{
	 code = "F17209  Nicotine dependence",
	 description = "unspecified",
	 additional = "with unspecified nicotine-induced disorders"
},
new ICD10
{
	 code = "F17210  Nicotine dependence",
	 description = "cigarettes",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F17211  Nicotine dependence",
	 description = "cigarettes",
	 additional = "in remission"
},
new ICD10
{
	 code = "F17213  Nicotine dependence",
	 description = "cigarettes",
	 additional = "with withdrawal"
},
new ICD10
{
	 code = "F17218  Nicotine dependence",
	 description = "cigarettes",
	 additional = "with other nicotine-induced disorders"
},
new ICD10
{
	 code = "F17219  Nicotine dependence",
	 description = "cigarettes",
	 additional = "with unspecified nicotine-induced disorders"
},
new ICD10
{
	 code = "F17220  Nicotine dependence",
	 description = "chewing tobacco",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F17221  Nicotine dependence",
	 description = "chewing tobacco",
	 additional = "in remission"
},
new ICD10
{
	 code = "F17223  Nicotine dependence",
	 description = "chewing tobacco",
	 additional = "with withdrawal"
},
new ICD10
{
	 code = "F17228  Nicotine dependence",
	 description = "chewing tobacco",
	 additional = "with other nicotine-induced disorders"
},
new ICD10
{
	 code = "F17229  Nicotine dependence",
	 description = "chewing tobacco",
	 additional = "with unspecified nicotine-induced disorders"
},
new ICD10
{
	 code = "F17290  Nicotine dependence",
	 description = "other tobacco product",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F17291  Nicotine dependence",
	 description = "other tobacco product",
	 additional = "in remission"
},
new ICD10
{
	 code = "F17293  Nicotine dependence",
	 description = "other tobacco product",
	 additional = "with withdrawal"
},
new ICD10
{
	 code = "F17298  Nicotine dependence",
	 description = "other tobacco product",
	 additional = "with other nicotine-induced disorders"
},
new ICD10
{
	 code = "F17299  Nicotine dependence",
	 description = "other tobacco product",
	 additional = "with unspecified nicotine-induced disorders"
},
new ICD10
{
	 code = "F1810",
	 description = "Inhalant",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F18120",
	 description = "Inhalant",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F18121",
	 description = " Inhalant abuse with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F18129",
	 description = "Inhalant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1814",
	 description = " Inhalant abuse with inhalant-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F18150",
	 description = " Inhalant abuse with inhalant-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F18151",
	 description = " Inhalant abuse with inhalant-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F18159",
	 description = "Inhalant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1817",
	 description = " Inhalant abuse with inhalant-induced dementia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F18180",
	 description = " Inhalant abuse with inhalant-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F18188",
	 description = " Inhalant abuse with other inhalant-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1819",
	 description = " Inhalant abuse with unspecified inhalant-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1820",
	 description = "Inhalant",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F1821",
	 description = "Inhalant",
	 additional = "in remission"
},
new ICD10
{
	 code = "F18220",
	 description = "Inhalant",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F18221",
	 description = " Inhalant dependence with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F18229",
	 description = "Inhalant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1824",
	 description = " Inhalant dependence with inhalant-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F18250",
	 description = " Inhalant dependence with inhalant-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F18251",
	 description = " Inhalant dependence with inhalant-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F18259",
	 description = "Inhalant",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1827",
	 description = " Inhalant dependence with inhalant-induced dementia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F18280",
	 description = " Inhalant dependence with inhalant-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F18288",
	 description = " Inhalant dependence with other inhalant-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1829",
	 description = " Inhalant dependence with unspecified inhalant-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1890   Inhalant use",
	 description = "unspecified",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F18920  Inhalant use",
	 description = "unspecified with intoxication",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F18921",
	 description = "Inhalant",
	 additional = "unspecified with intoxication with delirium"
},
new ICD10
{
	 code = "F18929  Inhalant use",
	 description = "unspecified with intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1894",
	 description = "Inhalant",
	 additional = "unspecified with inhalant-induced mood disorder"
},
new ICD10
{
	 code = "F18950",
	 description = "Inhalant",
	 additional = "unspecified with inhalant-induced psychotic disorder with delusions"
},
new ICD10
{
	 code = "F18951",
	 description = "Inhalant",
	 additional = "unspecified with inhalant-induced psychotic disorder with hallucinations"
},
new ICD10
{
	 code = "F18959  Inhalant use",
	 description = "unspecified with inhalant-induced psychotic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1897",
	 description = "Inhalant",
	 additional = "unspecified with inhalant-induced persisting dementia"
},
new ICD10
{
	 code = "F18980",
	 description = "Inhalant",
	 additional = "unspecified with inhalant-induced anxiety disorder"
},
new ICD10
{
	 code = "F18988",
	 description = "Inhalant",
	 additional = "unspecified with other inhalant-induced disorder"
},
new ICD10
{
	 code = "F1899",
	 description = "Inhalant",
	 additional = "unspecified with unspecified inhalant-induced disorder"
},
new ICD10
{
	 code = "F1910",
	 description = "Other",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F19120",
	 description = "Other",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F19121",
	 description = " Other psychoactive substance abuse with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19122",
	 description = " Other psychoactive substance abuse with intoxication with perceptual disturbances",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19129",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1914",
	 description = " Other psychoactive substance abuse with psychoactive substance-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19150",
	 description = " Other psychoactive substance abuse with psychoactive substance-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19151",
	 description = " Other psychoactive substance abuse with psychoactive substance-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19159",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1916",
	 description = " Other psychoactive substance abuse with psychoactive substance-induced persisting amnestic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1917",
	 description = " Other psychoactive substance abuse with psychoactive substance-induced persisting dementia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19180",
	 description = " Other psychoactive substance abuse with psychoactive substance-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19181",
	 description = " Other psychoactive substance abuse with psychoactive substance-induced sexual dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19182",
	 description = " Other psychoactive substance abuse with psychoactive substance-induced sleep disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19188",
	 description = " Other psychoactive substance abuse with other psychoactive substance-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1919",
	 description = " Other psychoactive substance abuse with unspecified psychoactive substance-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1920",
	 description = "Other",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F1921",
	 description = "Other",
	 additional = "in remission"
},
new ICD10
{
	 code = "F19220",
	 description = "Other",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F19221",
	 description = " Other psychoactive substance dependence with intoxication delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19222",
	 description = " Other psychoactive substance dependence with intoxication with perceptual disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19229",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19230",
	 description = "Other",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F19231",
	 description = " Other psychoactive substance dependence with withdrawal delirium",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19232",
	 description = " Other psychoactive substance dependence with withdrawal with perceptual disturbance",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19239",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1924",
	 description = " Other psychoactive substance dependence with psychoactive substance-induced mood disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19250",
	 description = " Other psychoactive substance dependence with psychoactive substance-induced psychotic disorder with delusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19251",
	 description = " Other psychoactive substance dependence with psychoactive substance-induced psychotic disorder with hallucinations",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19259",
	 description = "Other",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1926",
	 description = " Other psychoactive substance dependence with psychoactive substance-induced persisting amnestic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1927",
	 description = " Other psychoactive substance dependence with psychoactive substance-induced persisting dementia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19280",
	 description = " Other psychoactive substance dependence with psychoactive substance-induced anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19281",
	 description = " Other psychoactive substance dependence with psychoactive substance-induced sexual dysfunction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19282",
	 description = " Other psychoactive substance dependence with psychoactive substance-induced sleep disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19288",
	 description = " Other psychoactive substance dependence with other psychoactive substance-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1929",
	 description = " Other psychoactive substance dependence with unspecified psychoactive substance-induced disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1990   Other psychoactive substance use",
	 description = "unspecified",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F19920  Other psychoactive substance use",
	 description = "unspecified with intoxication",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F19921",
	 description = "Other",
	 additional = "unspecified with intoxication with delirium"
},
new ICD10
{
	 code = "F19922",
	 description = "Other",
	 additional = "unspecified with intoxication with perceptual disturbance"
},
new ICD10
{
	 code = "F19929  Other psychoactive substance use",
	 description = "unspecified with intoxication",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F19930  Other psychoactive substance use",
	 description = "unspecified with withdrawal",
	 additional = "uncomplicated"
},
new ICD10
{
	 code = "F19931",
	 description = "Other",
	 additional = "unspecified with withdrawal delirium"
},
new ICD10
{
	 code = "F19932",
	 description = "Other",
	 additional = "unspecified with withdrawal with perceptual disturbance"
},
new ICD10
{
	 code = "F19939  Other psychoactive substance use",
	 description = "unspecified with withdrawal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1994",
	 description = "Other",
	 additional = "unspecified with psychoactive substance-induced mood disorder"
},
new ICD10
{
	 code = "F19950",
	 description = "Other",
	 additional = "unspecified with psychoactive substance-induced psychotic disorder with delusions"
},
new ICD10
{
	 code = "F19951",
	 description = "Other",
	 additional = "unspecified with psychoactive substance-induced psychotic disorder with hallucinations"
},
new ICD10
{
	 code = "F19959  Other psychoactive substance use",
	 description = "unspecified with psychoactive substance-induced psychotic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F1996",
	 description = "Other",
	 additional = "unspecified with psychoactive substance-induced persisting amnestic disorder"
},
new ICD10
{
	 code = "F1997",
	 description = "Other",
	 additional = "unspecified with psychoactive substance-induced persisting dementia"
},
new ICD10
{
	 code = "F19980",
	 description = "Other",
	 additional = "unspecified with psychoactive substance-induced anxiety disorder"
},
new ICD10
{
	 code = "F19981",
	 description = "Other",
	 additional = "unspecified with psychoactive substance-induced sexual dysfunction"
},
new ICD10
{
	 code = "F19982",
	 description = "Other",
	 additional = "unspecified with psychoactive substance-induced sleep disorder"
},
new ICD10
{
	 code = "F19988",
	 description = "Other",
	 additional = "unspecified with other psychoactive substance-induced disorder"
},
new ICD10
{
	 code = "F1999",
	 description = "Other",
	 additional = "unspecified with unspecified psychoactive substance-induced disorder"
},
new ICD10
{
	 code = "F200",
	 description = " Paranoid schizophrenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F201",
	 description = " Disorganized schizophrenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F202",
	 description = " Catatonic schizophrenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F203",
	 description = " Undifferentiated schizophrenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F205",
	 description = " Residual schizophrenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F2081",
	 description = " Schizophreniform disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F2089",
	 description = " Other schizophrenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F209",
	 description = "Schizophrenia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F21",
	 description = " Schizotypal disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F22",
	 description = " Delusional disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F23",
	 description = " Brief psychotic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F24",
	 description = " Shared psychotic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F250",
	 description = "Schizoaffective",
	 additional = "bipolar type"
},
new ICD10
{
	 code = "F251",
	 description = "Schizoaffective",
	 additional = "depressive type"
},
new ICD10
{
	 code = "F258",
	 description = " Other schizoaffective disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F259",
	 description = "Schizoaffective",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F28",
	 description = " Other psychotic disorder not due to a substance or known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F29",
	 description = " Unspecified psychosis not due to a substance or known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F3010",
	 description = "Manic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F3011",
	 description = "Manic",
	 additional = "mild"
},
new ICD10
{
	 code = "F3012",
	 description = "Manic",
	 additional = "moderate"
},
new ICD10
{
	 code = "F3013   Manic episode",
	 description = "severe",
	 additional = "without psychotic symptoms"
},
new ICD10
{
	 code = "F302",
	 description = "Manic",
	 additional = "severe with psychotic symptoms"
},
new ICD10
{
	 code = "F303",
	 description = " Manic episode in partial remission",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F304",
	 description = " Manic episode in full remission",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F308",
	 description = " Other manic episodes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F309",
	 description = "Manic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F310",
	 description = "Bipolar",
	 additional = "current episode hypomanic"
},
new ICD10
{
	 code = "F3110   Bipolar disorder",
	 description = "current episode manic without psychotic features",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F3111   Bipolar disorder",
	 description = "current episode manic without psychotic features",
	 additional = "mild"
},
new ICD10
{
	 code = "F3112   Bipolar disorder",
	 description = "current episode manic without psychotic features",
	 additional = "moderate"
},
new ICD10
{
	 code = "F3113   Bipolar disorder",
	 description = "current episode manic without psychotic features",
	 additional = "severe"
},
new ICD10
{
	 code = "F312",
	 description = "Bipolar",
	 additional = "current episode manic severe with psychotic features"
},
new ICD10
{
	 code = "F3130",
	 description = " Bipolar disorder, current episode depressed, mild or moderate severity, unspecified",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F3131   Bipolar disorder",
	 description = "current episode depressed",
	 additional = "mild"
},
new ICD10
{
	 code = "F3132   Bipolar disorder",
	 description = "current episode depressed",
	 additional = "moderate"
},
new ICD10
{
	 code = "F314",
	 description = " Bipolar disorder, current episode depressed, severe, without psychotic features",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F315",
	 description = " Bipolar disorder, current episode depressed, severe, with psychotic features",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F3160   Bipolar disorder",
	 description = "current episode mixed",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F3161   Bipolar disorder",
	 description = "current episode mixed",
	 additional = "mild"
},
new ICD10
{
	 code = "F3162   Bipolar disorder",
	 description = "current episode mixed",
	 additional = "moderate"
},
new ICD10
{
	 code = "F3163",
	 description = " Bipolar disorder, current episode mixed, severe, without psychotic features",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F3164",
	 description = " Bipolar disorder, current episode mixed, severe, with psychotic features",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F3170   Bipolar disorder",
	 description = "currently in remission",
	 additional = "most recent episode unspecified"
},
new ICD10
{
	 code = "F3171   Bipolar disorder",
	 description = "in partial remission",
	 additional = "most recent episode hypomanic"
},
new ICD10
{
	 code = "F3172   Bipolar disorder",
	 description = "in full remission",
	 additional = "most recent episode hypomanic"
},
new ICD10
{
	 code = "F3173   Bipolar disorder",
	 description = "in partial remission",
	 additional = "most recent episode manic"
},
new ICD10
{
	 code = "F3174   Bipolar disorder",
	 description = "in full remission",
	 additional = "most recent episode manic"
},
new ICD10
{
	 code = "F3175   Bipolar disorder",
	 description = "in partial remission",
	 additional = "most recent episode depressed"
},
new ICD10
{
	 code = "F3176   Bipolar disorder",
	 description = "in full remission",
	 additional = "most recent episode depressed"
},
new ICD10
{
	 code = "F3177   Bipolar disorder",
	 description = "in partial remission",
	 additional = "most recent episode mixed"
},
new ICD10
{
	 code = "F3178   Bipolar disorder",
	 description = "in full remission",
	 additional = "most recent episode mixed"
},
new ICD10
{
	 code = "F3181",
	 description = " Bipolar II disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F3189",
	 description = " Other bipolar disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F319",
	 description = "Bipolar",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F320    Major depressive disorder",
	 description = "single episode",
	 additional = "mild"
},
new ICD10
{
	 code = "F321    Major depressive disorder",
	 description = "single episode",
	 additional = "moderate"
},
new ICD10
{
	 code = "F322    Major depressive disorder",
	 description = "single episode",
	 additional = "severe without psychotic features"
},
new ICD10
{
	 code = "F323    Major depressive disorder",
	 description = "single episode",
	 additional = "severe with psychotic features"
},
new ICD10
{
	 code = "F324    Major depressive disorder",
	 description = "single episode",
	 additional = "in partial remission"
},
new ICD10
{
	 code = "F325    Major depressive disorder",
	 description = "single episode",
	 additional = "in full remission"
},
new ICD10
{
	 code = "F328",
	 description = " Other depressive episodes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F329    Major depressive disorder",
	 description = "single episode",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F330    Major depressive disorder",
	 description = "recurrent",
	 additional = "mild"
},
new ICD10
{
	 code = "F331    Major depressive disorder",
	 description = "recurrent",
	 additional = "moderate"
},
new ICD10
{
	 code = "F332",
	 description = "Major",
	 additional = "recurrent severe without psychotic features"
},
new ICD10
{
	 code = "F333    Major depressive disorder",
	 description = "recurrent",
	 additional = "severe with psychotic symptoms"
},
new ICD10
{
	 code = "F3340",
	 description = " Major depressive disorder, recurrent, in remission, unspecified",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F3341   Major depressive disorder",
	 description = "recurrent",
	 additional = "in partial remission"
},
new ICD10
{
	 code = "F3342   Major depressive disorder",
	 description = "recurrent",
	 additional = "in full remission"
},
new ICD10
{
	 code = "F338",
	 description = " Other recurrent depressive disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F339    Major depressive disorder",
	 description = "recurrent",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F340",
	 description = " Cyclothymic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F341",
	 description = " Dysthymic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F348",
	 description = " Other persistent mood [affective] disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F349",
	 description = "Persistent",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F39",
	 description = " Unspecified mood [affective] disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4000",
	 description = "Agoraphobia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4001",
	 description = " Agoraphobia with panic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4002",
	 description = " Agoraphobia without panic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4010",
	 description = "Social",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4011",
	 description = "Social",
	 additional = "generalized"
},
new ICD10
{
	 code = "F40210",
	 description = " Arachnophobia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40218",
	 description = " Other animal type phobia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40220",
	 description = " Fear of thunderstorms",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40228",
	 description = " Other natural environment type phobia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40230",
	 description = " Fear of blood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40231",
	 description = " Fear of injections and transfusions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40232",
	 description = " Fear of other medical care",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40233",
	 description = " Fear of injury",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40240",
	 description = " Claustrophobia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40241",
	 description = " Acrophobia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40242",
	 description = " Fear of bridges",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40243",
	 description = " Fear of flying",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40248",
	 description = " Other situational type phobia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40290",
	 description = " Androphobia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40291",
	 description = " Gynephobia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F40298",
	 description = " Other specified phobia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F408",
	 description = " Other phobic anxiety disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F409",
	 description = "Phobic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F410",
	 description = " Panic disorder [episodic paroxysmal anxiety] without agoraphobia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F411",
	 description = " Generalized anxiety disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F413",
	 description = " Other mixed anxiety disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F418",
	 description = " Other specified anxiety disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F419",
	 description = "Anxiety",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F42",
	 description = " Obsessive-compulsive disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F430",
	 description = " Acute stress reaction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4310",
	 description = "Post-traumatic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4311",
	 description = "Post-traumatic",
	 additional = "acute"
},
new ICD10
{
	 code = "F4312",
	 description = "Post-traumatic",
	 additional = "chronic"
},
new ICD10
{
	 code = "F4320",
	 description = "Adjustment",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4321",
	 description = " Adjustment disorder with depressed mood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4322",
	 description = " Adjustment disorder with anxiety",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4323",
	 description = " Adjustment disorder with mixed anxiety and depressed mood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4324",
	 description = " Adjustment disorder with disturbance of conduct",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4325",
	 description = " Adjustment disorder with mixed disturbance of emotions and conduct",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4329",
	 description = " Adjustment disorder with other symptoms",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F438",
	 description = " Other reactions to severe stress",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F439",
	 description = "Reaction",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F440",
	 description = " Dissociative amnesia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F441",
	 description = " Dissociative fugue",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F442",
	 description = " Dissociative stupor",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F444",
	 description = " Conversion disorder with motor symptom or deficit",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F445",
	 description = " Conversion disorder with seizures or convulsions",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F446",
	 description = " Conversion disorder with sensory symptom or deficit",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F447",
	 description = " Conversion disorder with mixed symptom presentation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4481",
	 description = " Dissociative identity disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4489",
	 description = " Other dissociative and conversion disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F449",
	 description = "Dissociative",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F450",
	 description = " Somatization disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F451",
	 description = " Undifferentiated somatoform disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4520",
	 description = "Hypochondriacal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4521",
	 description = " Hypochondriasis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4522",
	 description = " Body dysmorphic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4529",
	 description = " Other hypochondriacal disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4541",
	 description = " Pain disorder exclusively related to psychological factors",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F4542",
	 description = " Pain disorder with related psychological factors",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F458",
	 description = " Other somatoform disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F459",
	 description = "Somatoform",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F481",
	 description = " Depersonalization-derealization syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F488",
	 description = " Other specified nonpsychotic mental disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F489",
	 description = "Nonpsychotic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5000",
	 description = "Anorexia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5001",
	 description = "Anorexia",
	 additional = "restricting type"
},
new ICD10
{
	 code = "F5002",
	 description = "Anorexia",
	 additional = "binge eating/purging type"
},
new ICD10
{
	 code = "F502",
	 description = " Bulimia nervosa",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F508",
	 description = " Other eating disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F509",
	 description = "Eating",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5101",
	 description = " Primary insomnia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5102",
	 description = " Adjustment insomnia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5103",
	 description = " Paradoxical insomnia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5104",
	 description = " Psychophysiologic insomnia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5105",
	 description = " Insomnia due to other mental disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5109",
	 description = " Other insomnia not due to a substance or known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5111",
	 description = " Primary hypersomnia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5112",
	 description = " Insufficient sleep syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5113",
	 description = " Hypersomnia due to other mental disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5119",
	 description = " Other hypersomnia not due to a substance or known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F513",
	 description = " Sleepwalking [somnambulism]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F514",
	 description = " Sleep terrors [night terrors]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F515",
	 description = " Nightmare disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F518",
	 description = " Other sleep disorders not due to a substance or known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F519",
	 description = "Sleep",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F520",
	 description = " Hypoactive sexual desire disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F521",
	 description = " Sexual aversion disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5221",
	 description = " Male erectile disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5222",
	 description = " Female sexual arousal disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5231",
	 description = " Female orgasmic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F5232",
	 description = " Male orgasmic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F524",
	 description = " Premature ejaculation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F525",
	 description = " Vaginismus not due to a substance or known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F526",
	 description = " Dyspareunia not due to a substance or known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F528",
	 description = " Other sexual dysfunction not due to a substance or known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F529",
	 description = " Unspecified sexual dysfunction not due to a substance or known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F53",
	 description = " Puerperal psychosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F54",
	 description = " Psychological and behavioral factors associated with disorders or diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F550",
	 description = " Abuse of antacids",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F551",
	 description = " Abuse of herbal or folk remedies",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F552",
	 description = " Abuse of laxatives",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F553",
	 description = " Abuse of steroids or hormones",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F554",
	 description = " Abuse of vitamins",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F558",
	 description = " Abuse of other non-psychoactive substances",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F59",
	 description = " Unspecified behavioral syndromes associated with physiological disturbances and physical factors",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F600",
	 description = " Paranoid personality disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F601",
	 description = " Schizoid personality disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F602",
	 description = " Antisocial personality disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F603",
	 description = " Borderline personality disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F604",
	 description = " Histrionic personality disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F605",
	 description = " Obsessive-compulsive personality disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F606",
	 description = " Avoidant personality disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F607",
	 description = " Dependent personality disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6081",
	 description = " Narcissistic personality disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6089",
	 description = " Other specific personality disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F609",
	 description = "Personality",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F630",
	 description = " Pathological gambling",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F631",
	 description = " Pyromania",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F632",
	 description = " Kleptomania",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F633",
	 description = " Trichotillomania",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6381",
	 description = " Intermittent explosive disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6389",
	 description = " Other impulse disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F639",
	 description = "Impulse",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F641",
	 description = " Gender identity disorder in adolescence and adulthood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F642",
	 description = " Gender identity disorder of childhood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F648",
	 description = " Other gender identity disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F649",
	 description = "Gender",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F650",
	 description = " Fetishism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F651",
	 description = " Transvestic fetishism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F652",
	 description = " Exhibitionism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F653",
	 description = " Voyeurism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F654",
	 description = " Pedophilia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6550",
	 description = "Sadomasochism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6551",
	 description = " Sexual masochism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6552",
	 description = " Sexual sadism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6581",
	 description = " Frotteurism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6589",
	 description = " Other paraphilias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F659",
	 description = "Paraphilia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F66",
	 description = " Other sexual disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6810",
	 description = "Factitious",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6811",
	 description = " Factitious disorder with predominantly psychological signs and symptoms",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6812",
	 description = " Factitious disorder with predominantly physical signs and symptoms",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F6813",
	 description = " Factitious disorder with combined psychological and physical signs and symptoms",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F688",
	 description = " Other specified disorders of adult personality and behavior",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F69",
	 description = " Unspecified disorder of adult personality and behavior",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F70",
	 description = " Mild mental retardation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F71",
	 description = " Moderate mental retardation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F72",
	 description = " Severe mental retardation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F73",
	 description = " Profound mental retardation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F78",
	 description = " Other mental retardation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F79",
	 description = " Unspecified mental retardation",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F800",
	 description = " Phonological disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F801",
	 description = " Expressive language disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F802",
	 description = " Mixed receptive-expressive language disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F803",
	 description = " Acquired aphasia with epilepsy [Landau-Kleffner]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F804",
	 description = " Speech and language development delay due to hearing loss",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F808",
	 description = " Other developmental disorders of speech or language",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F809",
	 description = "Developmental",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F810",
	 description = " Specific reading disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F812",
	 description = " Mathematics disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F8181",
	 description = " Disorder of written expression",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F8189",
	 description = " Other developmental disorders of scholastic skills",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F819",
	 description = "Developmental",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F82",
	 description = " Specific developmental disorder of motor function",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F840",
	 description = " Autistic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F842",
	 description = " Rett's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F843",
	 description = " Other childhood disintegrative disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F845",
	 description = " Asperger's syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F848",
	 description = " Other pervasive developmental disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F849",
	 description = "Pervasive",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F88",
	 description = " Other disorders of psychological development",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F89",
	 description = " Unspecified disorder of psychological development",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F900",
	 description = "Attention-deficit",
	 additional = "predominantly inattentive type"
},
new ICD10
{
	 code = "F901",
	 description = "Attention-deficit",
	 additional = "predominantly hyperactive type"
},
new ICD10
{
	 code = "F902",
	 description = "Attention-deficit",
	 additional = "combined type"
},
new ICD10
{
	 code = "F908",
	 description = "Attention-deficit",
	 additional = "other type"
},
new ICD10
{
	 code = "F909",
	 description = "Attention-deficit",
	 additional = "unspecified type"
},
new ICD10
{
	 code = "F910",
	 description = " Conduct disorder confined to family context",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F911",
	 description = "Conduct",
	 additional = "childhood-onset type"
},
new ICD10
{
	 code = "F912",
	 description = "Conduct",
	 additional = "adolescent-onset type"
},
new ICD10
{
	 code = "F913",
	 description = " Oppositional defiant disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F918",
	 description = " Other conduct disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F919",
	 description = "Conduct",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F930",
	 description = " Separation anxiety disorder of childhood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F938",
	 description = " Other childhood emotional disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F939",
	 description = "Childhood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F940",
	 description = " Selective mutism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F941",
	 description = " Reactive attachment disorder of childhood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F942",
	 description = " Disinhibited attachment disorder of childhood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F948",
	 description = " Other childhood disorders of social functioning",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F949",
	 description = "Childhood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F950",
	 description = " Transient tic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F951",
	 description = " Chronic motor or vocal tic disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F952",
	 description = " Tourette's disorder",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F958",
	 description = " Other tic disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F959",
	 description = "Tic",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F980",
	 description = " Enuresis not due to a substance or known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F981",
	 description = " Encopresis not due to a substance or known physiological condition",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F9821",
	 description = " Rumination disorder of infancy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F9829",
	 description = " Other feeding disorders of infancy and early childhood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F983",
	 description = " Pica of infancy and childhood",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F984",
	 description = " Stereotyped movement disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F985",
	 description = " Stuttering [stammering]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F988",
	 description = " Other specified behavioral and emotional disorders with onset usually occurring in childhood and adolescence",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F989",
	 description = " Unspecified behavioral and emotional disorders with onset usually occurring in childhood and adolescence",
	 additional = "unspecified"
},
new ICD10
{
	 code = "F99",
	 description = "Mental",
	 additional = "not otherwise specified"
},
new ICD10
{
	 code = "G000",
	 description = " Hemophilus meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G001",
	 description = " Pneumococcal meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G002",
	 description = " Streptococcal meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G003",
	 description = " Staphylococcal meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G008",
	 description = " Other bacterial meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G009",
	 description = "Bacterial",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G01",
	 description = " Meningitis in bacterial diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G02",
	 description = " Meningitis in other infectious and parasitic diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G030",
	 description = " Nonpyogenic meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G031",
	 description = " Chronic meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G032",
	 description = " Benign recurrent meningitis [Mollaret]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G038",
	 description = " Meningitis due to other specified causes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G039",
	 description = "Meningitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G0400",
	 description = " Postinfectious acute disseminated encephalitis and encephalomyelitis (postinfectious ADEM)",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G0401",
	 description = "Postimmunization",
	 additional = "myelitis and encephalomyelitis"
},
new ICD10
{
	 code = "G041",
	 description = " Tropical spastic paraplegia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G042",
	 description = "Bacterial",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "G0430",
	 description = " Postinfectious acute necrotizing hemorrhagic encephalopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G0431",
	 description = " Postimmunization acute necrotizing hemorrhagic encephalopathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G0481",
	 description = " Other encephalitis and encephalomyelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G0489",
	 description = " Other myelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G0490",
	 description = "Encephalitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G0491",
	 description = "Myelitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G053",
	 description = " Encephalitis and encephalomyelitis in diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G054",
	 description = " Myelitis in diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G060",
	 description = " Intracranial abscess and granuloma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G061",
	 description = " Intraspinal abscess and granuloma",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G062",
	 description = "Extradural",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G07",
	 description = " Intracranial and intraspinal abscess and granuloma in diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G08",
	 description = " Intracranial and intraspinal phlebitis and thrombophlebitis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G09",
	 description = " Sequelae of inflammatory diseases of central nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G10",
	 description = " Huntington's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G110",
	 description = " Congenital nonprogressive ataxia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G111",
	 description = " Early-onset cerebellar ataxia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G112",
	 description = " Late-onset cerebellar ataxia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G113",
	 description = " Cerebellar ataxia with defective DNA repair",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G114",
	 description = " Hereditary spastic paraplegia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G118",
	 description = " Other hereditary ataxias",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G119",
	 description = "Hereditary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G120",
	 description = "Infantile",
	 additional = "type I [Werdnig-Hoffman]"
},
new ICD10
{
	 code = "G121",
	 description = " Other inherited spinal muscular atrophy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G1220",
	 description = "Motor",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G1221",
	 description = " Amyotrophic lateral sclerosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G1222",
	 description = " Progressive bulbar palsy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G1229",
	 description = " Other motor neuron disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G128",
	 description = " Other spinal muscular atrophies and related syndromes",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G129",
	 description = "Spinal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G130",
	 description = " Paraneoplastic neuromyopathy and neuropathy",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G131",
	 description = " Other systemic atrophy primarily affecting central nervous system in neoplastic disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G138",
	 description = " Systemic atrophy primarily affecting central nervous system in other diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G20",
	 description = " Parkinson's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G210",
	 description = " Malignant neuroleptic syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2111",
	 description = " Neuroleptic induced parkinsonism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2119",
	 description = " Other drug induced secondary parkinsonism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G212",
	 description = " Secondary parkinsonism due to other external agents",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G213",
	 description = " Postencephalitic parkinsonism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G214",
	 description = " Vascular parkinsonism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G218",
	 description = " Other secondary parkinsonism",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G219",
	 description = "Secondary",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G230",
	 description = " Hallervorden-Spatz disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G231",
	 description = " Progressive supranuclear ophthalmoplegia [Steele-Richardson-Olszewski]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G232",
	 description = " Striatonigral degeneration",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G238",
	 description = " Other specified degenerative diseases of basal ganglia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G239",
	 description = "Degenerative",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2401",
	 description = " Drug induced subacute dyskinesia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2402",
	 description = " Drug induced acute dystonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2409",
	 description = " Other drug induced dystonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G241",
	 description = " Genetic torsion dystonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G242",
	 description = " Idiopathic nonfamilial dystonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G243",
	 description = " Spasmodic torticollis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G244",
	 description = " Idiopathic orofacial dystonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G245",
	 description = " Blepharospasm",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G248",
	 description = " Other dystonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G249",
	 description = "Dystonia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G250",
	 description = " Essential tremor",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G251",
	 description = " Drug-induced tremor",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G252",
	 description = " Other specified forms of tremor",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G253",
	 description = " Myoclonus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G254",
	 description = " Drug-induced chorea",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G255",
	 description = " Other chorea",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2561",
	 description = " Drug induced tics",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2569",
	 description = " Other tics of organic origin",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2570",
	 description = "Drug",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2571",
	 description = " Drug induced akathisia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2579",
	 description = " Other drug induced movement disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2581",
	 description = " Restless legs syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2582",
	 description = " Stiff-man syndrome",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G2589",
	 description = " Other specified extrapyramidal and movement disorders",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G259",
	 description = "Extrapyramidal",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G26",
	 description = " Extrapyramidal and movement disorders in diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G300",
	 description = " Alzheimer's disease with early onset",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G301",
	 description = " Alzheimer's disease with late onset",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G308",
	 description = " Other Alzheimer's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G309",
	 description = "Alzheimer's",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G3101",
	 description = " Pick's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G3109",
	 description = " Other frontotemporal dementia",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G311",
	 description = "Senile",
	 additional = "not elsewhere classified"
},
new ICD10
{
	 code = "G312",
	 description = " Degeneration of nervous system due to alcohol",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G3181",
	 description = " Alpers' disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G3182",
	 description = " Leigh's disease",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G3183",
	 description = " Dementia with Lewy bodies",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G3184",
	 description = "Mild",
	 additional = "so stated"
},
new ICD10
{
	 code = "G3189",
	 description = " Other specified degenerative diseases of nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G319",
	 description = "Degenerative",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G320",
	 description = " Subacute combined degeneration of spinal cord in diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G328",
	 description = " Other specified degenerative disorders of nervous system in diseases classified elsewhere",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G35",
	 description = " Multiple sclerosis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G360",
	 description = " Neuromyelitis optica [Devic]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G361",
	 description = " Acute and subacute hemorrhagic leukoencephalitis [Hurst]",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G368",
	 description = " Other specified acute disseminated demyelination",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G369",
	 description = "Acute",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G370",
	 description = " Diffuse sclerosis of central nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G371",
	 description = " Central demyelination of corpus callosum",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G372",
	 description = " Central pontine myelinolysis",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G373",
	 description = " Acute transverse myelitis in demyelinating disease of central nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G374",
	 description = " Subacute necrotizing myelitis of central nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G375",
	 description = " Concentric sclerosis [Balo] of central nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G378",
	 description = " Other specified demyelinating diseases of central nervous system",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G379",
	 description = "Demyelinating",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G40001  Localization-related (focal) (partial) idiopathic epilepsy and epileptic syndromes with seizures of localized onset",
	 description = "not intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40009  Localization-related (focal) (partial) idiopathic epilepsy and epileptic syndromes with seizures of localized onset",
	 description = "not intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40011  Localization-related (focal) (partial) idiopathic epilepsy and epileptic syndromes with seizures of localized onset",
	 description = "intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40019  Localization-related (focal) (partial) idiopathic epilepsy and epileptic syndromes with seizures of localized onset",
	 description = "intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40101  Localization-related (focal) (partial) symptomatic epilepsy and epileptic syndromes with simple partial seizures",
	 description = "not intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40109  Localization-related (focal) (partial) symptomatic epilepsy and epileptic syndromes with simple partial seizures",
	 description = "not intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40111  Localization-related (focal) (partial) symptomatic epilepsy and epileptic syndromes with simple partial seizures",
	 description = "intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40119  Localization-related (focal) (partial) symptomatic epilepsy and epileptic syndromes with simple partial seizures",
	 description = "intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40201  Localization-related (focal) (partial) symptomatic epilepsy and epileptic syndromes with complex partial seizures",
	 description = "not intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40209  Localization-related (focal) (partial) symptomatic epilepsy and epileptic syndromes with complex partial seizures",
	 description = "not intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40211  Localization-related (focal) (partial) symptomatic epilepsy and epileptic syndromes with complex partial seizures",
	 description = "intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40219  Localization-related (focal) (partial) symptomatic epilepsy and epileptic syndromes with complex partial seizures",
	 description = "intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40301  Generalized idiopathic epilepsy and epileptic syndromes",
	 description = "not intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40309  Generalized idiopathic epilepsy and epileptic syndromes",
	 description = "not intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40311  Generalized idiopathic epilepsy and epileptic syndromes",
	 description = "intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40319  Generalized idiopathic epilepsy and epileptic syndromes",
	 description = "intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40401  Other generalized epilepsy and epileptic syndromes",
	 description = "not intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40409  Other generalized epilepsy and epileptic syndromes",
	 description = "not intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40411  Other generalized epilepsy and epileptic syndromes",
	 description = "intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40419  Other generalized epilepsy and epileptic syndromes",
	 description = "intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40501  Special epileptic syndromes",
	 description = "not intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40509  Special epileptic syndromes",
	 description = "not intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40511  Special epileptic syndromes",
	 description = "intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40519  Special epileptic syndromes",
	 description = "intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40801  Other epilepsy",
	 description = "not intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40809  Other epilepsy",
	 description = "not intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G40811  Other epilepsy",
	 description = "intractable",
	 additional = "with status epilepticus"
},
new ICD10
{
	 code = "G40819  Other epilepsy",
	 description = "intractable",
	 additional = "without status epilepticus"
},
new ICD10
{
	 code = "G4089",
	 description = " Other seizures",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G40901",
	 description = " Epilepsy, unspecified, not intractable, with status epilepticus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G40909",
	 description = " Epilepsy, unspecified, not intractable, without status epilepticus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G40911",
	 description = " Epilepsy, unspecified, intractable, with status epilepticus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G40919",
	 description = " Epilepsy, unspecified, intractable, without status epilepticus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G4300",
	 description = "Migraine",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G4301",
	 description = "Migraine",
	 additional = "intractable"
},
new ICD10
{
	 code = "G4310",
	 description = "Migraine",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G4311",
	 description = "Migraine",
	 additional = "intractable"
},
new ICD10
{
	 code = "G432",
	 description = " Status migrainosus",
	 additional = "unspecified"
},
new ICD10
{
	 code = "G4340",
	 description = "Hemiplegic",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G4341",
	 description = "Hemiplegic",
	 additional = "intractable"
},
new ICD10
{
	 code = "G4350",
	 description = "Menstrual",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G4351",
	 description = "Menstrual",
	 additional = "intractable"
},
new ICD10
{
	 code = "G43601  Persistent migraine aura",
	 description = "not intractable",
	 additional = "with cerebral infarction"
},
new ICD10
{
	 code = "G43609  Persistent migraine aura",
	 description = "not intractable",
	 additional = "without cerebral infarction"
},
new ICD10
{
	 code = "G43611  Persistent migraine aura",
	 description = "intractable",
	 additional = "with cerebral infarction"
},
new ICD10
{
	 code = "G43619  Persistent migraine aura",
	 description = "intractable",
	 additional = "without cerebral infarction"
},
new ICD10
{
	 code = "G4370",
	 description = "Chronic",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G4371",
	 description = "Chronic",
	 additional = "intractable"
},
new ICD10
{
	 code = "G43811",
	 description = "Cyclical",
	 additional = "intractable"
},
new ICD10
{
	 code = "G43819",
	 description = "Cyclical",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G43821",
	 description = "Ophthalmoplegic",
	 additional = "intractable"
},
new ICD10
{
	 code = "G43829",
	 description = "Ophthalmoplegic",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G43831",
	 description = "Periodic",
	 additional = "intractable"
},
new ICD10
{
	 code = "G43839",
	 description = "Periodic",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G43891",
	 description = "Other",
	 additional = "intractable"
},
new ICD10
{
	 code = "G43899",
	 description = "Other",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G4390   Migraine",
	 description = "unspecified",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G4391   Migraine",
	 description = "unspecified",
	 additional = "intractable"
},
new ICD10
{
	 code = "G44001  Cluster headache syndrome",
	 description = "unspecified",
	 additional = "intractable"
},
new ICD10
{
	 code = "G44009  Cluster headache syndrome",
	 description = "unspecified",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G44011",
	 description = "Episodic",
	 additional = "intractable"
},
new ICD10
{
	 code = "G44019",
	 description = "Episodic",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G44021",
	 description = "Chronic",
	 additional = "intractable"
},
new ICD10
{
	 code = "G44029",
	 description = "Chronic",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G44031",
	 description = "Episodic",
	 additional = "intractable"
},
new ICD10
{
	 code = "G44039",
	 description = "Episodic",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G44041",
	 description = "Chronic",
	 additional = "intractable"
},
new ICD10
{
	 code = "G44049",
	 description = "Chronic",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G44051",
	 description = "Short",
	 additional = "intractable"
},
new ICD10
{
	 code = "G44059",
	 description = "Short",
	 additional = "not intractable"
},
new ICD10
{
	 code = "G44091",
	 description = "Other",
	 additional = "intractable"
}
           );
        }
    }
}
