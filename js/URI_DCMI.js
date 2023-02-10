/*
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_DCMI 
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    <script type="module">
        import {URI_DCMI} from "./URI_DCMI.js"
        console.log(URI_DCMI.EVENT) | console.log(URI_DCMI["EVENT"])
        # both return "http://purl.org/dc/dcmitype/Event"
    </script>
License : https://mit-license.org
History :
10/02/2023 CFB Extracted from old script and converted to ES6 module
===============================================================================
*/
const NS = "http://purl.org/dc/dcmitype/"
export const URI_DCMI = Object.freeze({
    COLLECTION: `${NS}Collection`,
    DATASET: `${NS}Dataset`,
    EVENT: `${NS}Event`,
    IMAGE: `${NS}Image`,
    INTERACTIVERESOURCE: `${NS}InteractiveResource`,
    MOVINGIMAGE: `${NS}MovingImage`,
    PHYSICALOBJECT: `${NS}PhysicalObject`,
    SERVICE: `${NS}Service`,
    SOFTWARE: `${NS}Software`,
    SOUND: `${NS}Sound`,
    STILLIMAGE: `${NS}StillImage`,
    TEXT: `${NS}Text`
})