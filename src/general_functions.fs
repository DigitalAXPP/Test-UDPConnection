module general_functions

    open System.IO

    let tee_object f x =
        f x
        x 

    let writeToLog path message =
        File.AppendAllText (path, message + "\n")