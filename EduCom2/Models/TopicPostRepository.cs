﻿using EduComDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EduComDataLayer;
using EduCom2.Models.DTO;

namespace EduCom2.Models
{
    public class TopicPostRepository: ITopic
    {
        EduContext ectx = new EduContext();

        //method to display all topics on info page
            public List <Topic> GetAllTopics()
        {
            var topicList = ectx.Topics.ToList();
            return topicList;
        }

    }
}