using Grpc.Core;
using Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnGrpc.Server.Services
{
    public class NoteService:Notes.NoteService.NoteServiceBase
    {

        public override Task<Note> AddNote(AddNoteRequest request, ServerCallContext context)
        {
            return base.AddNote(request, context);
        }

        public override Task<GetNotesResponse> GetNotes(GetNotesRequest request, ServerCallContext context)
        {
            return base.GetNotes(request, context);
        }

        public override Task<Note> DeleteNote(DeleteNoteRequest request, ServerCallContext context)
        {
            return base.DeleteNote(request, context);
        }
    }
}
