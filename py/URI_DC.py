"""
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_DC
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    import URI_DC
    print(URI_DC.TITLE) # "http://purl.org/dc/elements/1.1/title"
License : https://mit-license.org
History :
23/02/2023 CFB Extracted from old script, updated to use F-strings
===============================================================================
"""
# Namespace
NS = "http://purl.org/dc/elements/1.1/"

# Properties
TITLE = f"{NS}title"
CREATOR = f"{NS}creator"
SUBJECT = f"{NS}subject"
DESCRIPTION = f"{NS}description"
PUBLISHER = f"{NS}publisher"
CONTRIBUTOR = f"{NS}contributor"
DATE = f"{NS}date"
TYPE = f"{NS}type"
FORMAT = f"{NS}format"
IDENTIFIER = f"{NS}identifier"
SOURCE = f"{NS}source"
LANGUAGE = f"{NS}language"
RELATION = f"{NS}relation"
COVERAGE = f"{NS}coverage"
RIGHTS = f"{NS}rights"
