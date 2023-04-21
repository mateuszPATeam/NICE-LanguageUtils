# NICE-LanguageUtils

Set of tools used for working with languages in **NICE RPA** suite. These tools are designed to help developers create automations that can work with multiple languages and identify the language of text. Under the hood, the language identification package used by these tools is provided by [Microsoft](https://www.microsoft.com/en-us/download/details.aspx?id=52575&from=http%3A%2F%2Fresearch.microsoft.com%2Fen-us%2Fdownloads%2F5a84b263-41d6-4ce1-a186-8e3f76efe2e5%2F). This package  implements several algorithms for language identification.

### Supported Languages:
- Afrikaans
- Arabic
- Belarusian
- Bulgarian
- Czech
- Danish
- German
- Greek
- English
- Spanish
- Estonian
- Persian
- Finnish
- French
- Hebrew
- Croatian
- Hungarian
- Icelandic
- Italian
- Japanese
- Georgian
- Luxembourgish
- Lithuanian
- Latvian
- Macedonian
- Dutch
- Norwegian
- Polish
- Portuguese
- Romanian
- Russian
- Slovak
- Slovene
- Turkish
- Chinese

### Available functions:
- Identify Text Language. 
  - Parameters:
    - **Text** (string) - Text to get the language for
    - **Languages Profiles** (string) - Path to a file with languages profiles
    - **Language Identification Method** (int) - Method of language identification that should be run. Available values:
      - 1 - Used method: [Vector](https://en.wikipedia.org/wiki/Cosine_similarity)
      - 2 - Used method: [Likely](https://www.sciencedirect.com/topics/mathematics/conditional-likelihood)
      - 3 - Used method: [Rank,sf](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&cad=rja&uact=8&ved=2ahUKEwjMkda_5rr-AhUDvYsKHV-NAkwQFnoECAwQAQ&url=https%3A%2F%2Fwww.kaggle.com%2Fgeneral%2F241837&usg=AOvVaw28UrID_k705fhy1ebpZmFD)
      - 4 - Used method: [Rank,sr](https://en.wikipedia.org/wiki/Spearman%27s_rank_correlation_coefficient)
  - Returns:
    - Language Identification Result type
 

    
    
### How to use:
 #### RT Designer:
  - For versions from 7.5 download the files from: https://github.com/pateam-rpa/NICE-LanguageUtils/tree/master/Packages/Designer%207.5%20onwards
  - For versions before 7.5 download the files from: https://github.com/pateam-rpa/NICE-LanguageUtils/tree/master/Packages/Designer%20before%207.5
  - Download the languages profiles: https://github.com/pateam-rpa/NICE-LanguageUtils/tree/master/LanguagesProfiles
  - Paste both .dll files into your installation folder
  - Open Designer Project
  - Add Library Reference to PAteam_LanguageUtils.dll
  - The function Identify Text Language will be available under Library Objects -> Language Utils
  - The Return type for the above function will be available under Library Objects -> General
 #### Automation Studio:
  - Download nuget package from: https://github.com/pateam-rpa/NICE-LanguageUtils/tree/master/Packages/Automation%20Studio
  - Paste downloaded nuget package into: %appdata%/nice_systems/automationstudio/nuget packages
  - Open Automation Studio Project
  - Import the package
  - The function Identify Text Language will be available under imported packages
  - The Return type for the above function will be available under Variables -> Complex Types -> Imported Types
