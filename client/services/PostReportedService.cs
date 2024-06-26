﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using client.models;
using client.repositories;
using client.servicesInterfaces;
namespace client.services
{
    internal class PostReportedService : IPostReportedService
    {
        IPostReportedRepository postReportedRepository;

        public PostReportedService(IPostReportedRepository _postReportedRepository)
        {
            postReportedRepository = _postReportedRepository;
        }

        public bool addPostReported(PostReported postReported)
        {


            return postReportedRepository.addReportedPostToDB(postReported);
        }

        public bool removePostReported(PostReported postReported)
        {


            return postReportedRepository.removeReportedPostFromDB(postReported);

        }

        public List<PostReported> getPostReportedList()
        {
            return postReportedRepository.getAll();
        }

    }
}
