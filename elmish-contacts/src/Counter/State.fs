module Counter.State

open Elmish
open Types

let init () : Model * Cmd<Msg> =
  { count = 0 }, []

let update msg model =
  match msg with
  | Increment ->
      model + 2, []
  | Decrement ->
      model - 1, []
  | Reset ->
      0, []
