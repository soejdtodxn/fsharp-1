// #ErrorMessages
//<Expects id="FS0010" status="error" span="(11,5)">Unexpected symbol '}' in expression.</Expects>

namespace ApplicativeComputationExpressions

module E_NoReturn =

    eventually {
        let! x = Eventually.NotYetDone (fun () -> Eventually.Done 4)
        and! y = Eventually.Done 6
    }