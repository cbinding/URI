/*
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_RDF 
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    <script type="module">
        import {URI_RDF} from "./URI_RDF.js"
        console.log(URI_RDF.BAG) | console.log(URI_RDF["BAG"])
        # both return "http://www.w3.org/1999/02/22-rdf-syntax-ns#Bag"
    </script>
License : https://mit-license.org
History :
10/02/2023 CFB Extracted from legacy script and converted to ES6 module
===============================================================================
*/
const NS = "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
export const URI_RDF = Object.freeze({
    // entities
    ALT: `${NS}Alt`,
    BAG: `${NS}Bag`,
    LIST: `${NS}List`,
    PROPERTY: `${NS}Property`,
    SEQ: `${NS}Seq`,
    STATEMENT: `${NS}Statement`,
    XMLLITERAL: `${NS}XMLLiteral`,
    // properties
    FIRST: `${NS}first`,
    ID: `${NS}ID`,
    OBJECT: `${NS}object`,
    PREDICATE: `${NS}predicate`,
    REST: `${NS}rest`,
    SUBJECT: `${NS}subject`,
    TYPE: `${NS}type`,
    VALUE: `${NS}value`
})