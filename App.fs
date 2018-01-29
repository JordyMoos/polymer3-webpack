module App.View

open Elmish
open Elmish.React
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props


importSideEffects "@polymer/paper-button/paper-button.js"


let inline paperButton b c = domEl "paper-button" b c


let root model dispatch =
  div [] [
    str "Hello"
    paperButton [] [ str "button" ]
  ]


// App
Program.mkSimple ignore (fun _ -> ignore) root
  |> Program.withReact "app"
  |> Program.run
