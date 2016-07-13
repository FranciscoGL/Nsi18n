# i18n

## Internationalization vs Localization
i18n = internationalization  
L10n = localization  

**Internationalization** is designing an application that can be be adapted for many different cultures.  
**Localization** is the adaptation of an application for a particular area or culture.

Process envolved:  
- Time zone  
- DateTime  
- Currency  
- Weights & measurements  
- Phone numbers
- Addresses  
- Character encoding (ASCII, UTF8, UTF16, etc.)

g11n = globalization  
t9n = translation  
L12y = localizability  
c13n = culturization  

## Culture
La cultura es el conjunto de formas y expresiones que caracterizarán en el tiempo a una sociedad determinada.
The word "culture" derives from a French term, which in turn derives from the Latin "colere," which means to tend to the earth and grow, or cultivation and nurture.
«La culture est l'ensemble des connaissances, des savoir-faire, des traditions, des coutumes, propres à un groupe humain, à une civilisation.»

### Identificación de L10n
- Language - For example, Spanish generally. ISO code "es"
- Locale - Mexico. Note that Spanish in Spain is not the same as Spanish in Mexico, e.g. "es-ES" vs. "es-MX"

La sintaxis utilizada para el código de localización es: ```<language>-<region>-<dialect>```, region y dialect son opcionales.
     ```<language>``` = ISO 639-1 (2 letras) o ISO 639-2 (3 letras).  
     ```<region>``` = ISO 3166 (2 letras).  
     ```<dialect>``` = 5 a 8 letras o un numero seguido por 3 letras o nros.

## Manejo de strings con la cultura. 
ToString:  
1. Number  
2. Currency
3. String order
4. Custom culture

## Invariantculture. 
The invariant culture is culture-insensitive; it is associated with the English language but not with any country/region.

## CurrentCulture vs CurrentUICulture. 
Culture drives things like number and date formats, currency symbols, sort order, casing etc.  
CultureUI uses for resource localization

## Como afecta esto a SQL?

### varchar  
* Non-Unicode
* Requires 1 byte of storage
* Best suited for US English

### nvarchar
* Unicode
* Requires 2 byte of storage
* Best suited for systems that need to support at least oneforeign language.

### Collation
Collation controls the way string values are sorted. The default collation sorts alphabetically using the standard Latin character set. Other collations will sort in different orders. For example, a traditional Spanish collation places words beginning with "ch" at the end of a list of words beginning with "c."

All shared MS SQL databases support Unicode characters, allowing the storage of a variety of alphabets.

Modifying collation settings is an advanced database task and should only be performed by experienced database developers.

### Collate

List of Collate Code:

SELECT * FROM sys .fn_helpcollations () WHERE name LIKE 'SQL%' ;

Is a clause that can be applied to a database definition or a column definition to define the collation, or to a character string expression to apply a collation cast.
