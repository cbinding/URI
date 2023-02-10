/*
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_DC 
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    <script type="module">
        import {URI_DC} from "./URI_DC.js"
        console.log(URI_DC.TITLE) | console.log(URI_DC["TITLE"])
        # both return "http://purl.org/dc/elements/1.1/title"
    </script>
License : https://mit-license.org
History :
10/02/2023 CFB Extracted from old script and converted to ES6 module
===============================================================================
*/
const NS = "http://purl.org/dc/elements/1.1/" 
export const URI_DC = Object.freeze({
    // properties
    CONTRIBUTOR: `${NS}contributor`,
    COVERAGE: `${NS}coverage`,
    CREATOR: `${NS}creator`,
    DATE: `${NS}date`,
    DESCRIPTION: `${NS}description`,
    FORMAT: `${NS}format`,
    IDENTIFIER: `${NS}identifier`,
    LANGUAGE: `${NS}language`,
    PUBLISHER: `${NS}publisher`,
    RELATION: `${NS}relation`,
    RIGHTS: `${NS}rights`,
    SOURCE: `${NS}source`,
    SUBJECT: `${NS}subject`,
    TITLE: `${NS}title`,
    TYPE: `${NS}type`
})