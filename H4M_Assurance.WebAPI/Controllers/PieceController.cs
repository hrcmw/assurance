using H4M_Assurance.Domain.Entities;
using H4M_Assurance.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace H4M_Assurance.WebAPI.Controllers
{
    public class PieceController : ApiController
    {
        IPieceService pieceSvc = new PieceService();
        // GET: api/Piece
        public IEnumerable<Piece> Get()
        {
            return pieceSvc.GetAll();
        }

        // GET: api/Piece/5
        public Piece Get(long id)
        {
            return pieceSvc.GetById(id);
        }

        // POST: api/Piece
        public void Post([FromBody]Piece piece)
        {
            Piece p = piece;

            pieceSvc.Add(p);
            pieceSvc.Commit();
        }

        // PUT: api/Piece/5
        public void Put(int id, [FromBody]Piece piece)
        {
            piece.IdPiece = id;
            pieceSvc.Update(piece);
            pieceSvc.Commit();
        }

        // DELETE: api/Piece/5
        public void Delete(int id)
        {
            Piece p = pieceSvc.GetById((long)id);
            pieceSvc.Delete(p);
            pieceSvc.Commit();
        }
    }
}
