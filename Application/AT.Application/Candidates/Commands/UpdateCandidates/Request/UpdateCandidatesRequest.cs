using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace AT.Application.Candidates.Commands.UpdateCandidates.Request
{
    public class UpdateCandidatesRequest : IRequest
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string PersonalNumber { get; set; } = string.Empty;
    }
}