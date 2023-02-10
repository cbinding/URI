/*
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_SKOSXL 
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    <script type="module">
        import {URI_SKOSXL} from "./URI_SKOSXL.js"
        console.log(URI_SKOSXL.LABEL) | console.log(URI_SKOSXL["LABEL"])
        # both return "http://www.w3.org/2008/05/skos-xl#Label"
    </script>
License : https://mit-license.org
History :
10/02/2023 CFB Extracted from old script and converted to ES6 module
===============================================================================
*/      
const NS = "http://www.w3.org/2008/05/skos-xl#" 
export const URI_SKOSXL = Object.freeze({
    // entities
    LABEL: `${NS}Label`,
    // properties
    ALTLABEL: `${NS}altLabel`,
    HIDDENLABEL: `${NS}hiddenLabel`,
    LABELRELATION: `${NS}labelRelation`,
    LITERALFORM: `${NS}literalForm`,
    PREFLABEL: `${NS}prefLabel`
})